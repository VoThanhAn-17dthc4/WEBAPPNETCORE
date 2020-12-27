using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class KhachHangController : Controller
    {
        private readonly UserManager<UserIdentity> _userManager;
        private readonly ITaiKhoan TaiKhoan = new TaiKhoanRepository();
        public KhachHangController(UserManager<UserIdentity> userManager)
        {
            _userManager = userManager;
        }
        // GET: KhachHangController
        public ActionResult Index(string txtInfo)
        {
            var model = TaiKhoan.SelectAll().Select(item => new TaiKhoanViewModel
            {
                TenTaiKhoan = item.TenTaiKhoan,
                HoVaTen = item.HoVaTen,
                Id = item.Id,
                NgayTao = item.NgayTao,
                Sdt = item.Sdt,
                IsDelete = item.IsDelete,
                TongTien = item.TongTien
            }).OrderByDescending(x => x.NgayTao).Where(x=>x.IsAdmin == false);
            if(txtInfo != null)
            {
                model = model.Where(x => Helper.Comon.ChuyenThanhKhongDau(x.HoVaTen).Contains(Helper.Comon.ChuyenThanhKhongDau(txtInfo)) || x.Sdt == txtInfo);
            }    
            return View(model);
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TaiKhoanController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TaiKhoanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateAsync(TaiKhoanViewModel model)
        {
            try
            {
                UserIdentity user = new UserIdentity
                {
                    UserName = model.TenTaiKhoan,
                    Email = model.TenTaiKhoan,
                };
                var result = await _userManager.CreateAsync(user, model.MatKhau);
                if (result.Succeeded)
                {
                    var item = new TaiKhoan();
                    item.HoVaTen = model.HoVaTen;
                    item.DiaChi = model.DiaChi;
                    item.IsAdmin = true;
                    item.IsDelete = false;
                    item.MatKhau = model.MatKhau;
                    item.TenTaiKhoan = model.TenTaiKhoan;
                    item.Sdt = model.Sdt;
                    item.NgayTao = DateTime.Now;
                    item.TongTien = 0;
                    TaiKhoan.Insert(item);
                    TaiKhoan.Save();
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaiKhoanController/Edit/5
        public ActionResult Edit(int id)
        {
            var tk = TaiKhoan.SelectById(id);
            var model = new TaiKhoanViewModel();
            model.Id = tk.Id;
            model.IsAdmin = tk.IsAdmin;
            model.IsDelete = tk.IsDelete;
            model.MatKhau = tk.MatKhau;
            model.NgayTao = tk.NgayTao;
            model.Sdt = tk.Sdt;
            model.TongTien = tk.TongTien;
            model.HoVaTen = tk.HoVaTen;
            model.TenTaiKhoan = tk.TenTaiKhoan;
            return View(model);
        }

        // POST: TaiKhoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(TaiKhoanViewModel model)
        {
            try
            {
                var tk = TaiKhoan.SelectById(model.Id);
                tk.MatKhau = model.MatKhau;
                tk.Sdt = model.Sdt;
                tk.HoVaTen = model.HoVaTen;
                tk.TenTaiKhoan = model.TenTaiKhoan;
                tk.DiaChi = model.DiaChi;
                TaiKhoan.Update(tk);
                TaiKhoan.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaiKhoanController/Delete/5
        public ActionResult Delete(int id)
        {
            var tk = TaiKhoan.SelectById(id);
            tk.IsDelete = true;
            TaiKhoan.Update(tk);
            TaiKhoan.Save();
            return View();
        }

    }
}
