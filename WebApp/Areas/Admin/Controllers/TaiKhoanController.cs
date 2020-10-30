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
        private readonly UserManager<UserIdentity> _userManager;
        private readonly ITaiKhoan TaiKhoan = new TaiKhoanRepository();
        public TaiKhoanController(UserManager<UserIdentity> userManager)
        {
            _userManager = userManager;
        }
        // GET: TaiKhoanController
        public ActionResult Index()
        {
            var model = TaiKhoan.SelectAll().Select(item => new TaiKhoanViewModel
            {
                TenTaiKhoan = item.TenTaiKhoan,
                HoVaTen = item.HoVaTen,
                Id = item.Id,
                NgayTao = item.NgayTao,
                Sdt = item.Sdt,
                IsDelete = item.IsDelete
            }).OrderByDescending(x=>x.NgayTao);
            return View(model);
        }

        // GET: TaiKhoanController/Details/5
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
                if(result.Succeeded)
                {
                    var item = new TaiKhoan();
                    item.HoVaTen = model.HoVaTen;
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
            return View();
        }

        // POST: TaiKhoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
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
            return View();
        }

        // POST: TaiKhoanController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
