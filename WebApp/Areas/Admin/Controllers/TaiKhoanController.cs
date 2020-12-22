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
    public class TaiKhoanController : Controller
    {
        private readonly SignInManager<UserIdentity> _signInManager;
        private readonly UserManager<UserIdentity> _userManager;
        private readonly ITaiKhoan TaiKhoan = new TaiKhoanRepository();
        public TaiKhoanController(UserManager<UserIdentity> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost]
        public async Task<IActionResult> LogOut()
        {
            await _signInManager.SignOutAsync();
            HttpContext.Session.Remove("nameadmin");
            return View();
        }
        // GET: TaiKhoanController
        public ActionResult Index()
        {
            IEnumerable<TaiKhoanViewModel> model = TaiKhoan.SelectAll().Select(item => new TaiKhoanViewModel
            {
                TenTaiKhoan = item.TenTaiKhoan,
                HoVaTen = item.HoVaTen,
                Id = item.Id,
                NgayTao = item.NgayTao,
                Sdt = item.Sdt,
                IsDelete = item.IsDelete,
                IsAdmin = item.IsAdmin,
                DiaChi = item.DiaChi,
                TongTien = item.TongTien
            }).OrderByDescending(x=>x.NgayTao).Where(x=>x.IsAdmin == true);
            return View(model);
        }
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> Create(TaiKhoanViewModel model)
        {
            var item = new TaiKhoan();
            item.HoVaTen = model.HoVaTen;
            item.IsAdmin = true;
            item.IsDelete = false;
            item.MatKhau = model.MatKhau;
            item.DiaChi = model.DiaChi;
            item.TenTaiKhoan = model.TenTaiKhoan;
            item.Sdt = model.Sdt;
            item.NgayTao = DateTime.Now;
            item.TongTien = 0;
            TaiKhoan.Insert(item);
            TaiKhoan.Save();
            return View();
        }
        public ActionResult Edit(int? id)
        {
            var item = new TaiKhoanViewModel();
            var model = TaiKhoan.SelectById(id);
            item.HoVaTen = model.HoVaTen;
            item.IsAdmin = model.IsAdmin;
            item.IsDelete = model.IsDelete;
            item.MatKhau = model.MatKhau;
            item.DiaChi = model.DiaChi;
            item.TenTaiKhoan = model.TenTaiKhoan;
            item.Sdt = model.Sdt;
            item.NgayTao = model.NgayTao;
            item.TongTien = model.TongTien;
            return View(item);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(TaiKhoanViewModel item)
        {
            var model = TaiKhoan.SelectById(item.Id);
            item.HoVaTen = model.HoVaTen;
            item.MatKhau = model.MatKhau;
            item.DiaChi = model.DiaChi;
            item.TenTaiKhoan = model.TenTaiKhoan;
            item.Sdt = model.Sdt;
            TaiKhoan.Update(model);
            TaiKhoan.Save();
            return View();
        }
        // GET: TaiKhoanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
