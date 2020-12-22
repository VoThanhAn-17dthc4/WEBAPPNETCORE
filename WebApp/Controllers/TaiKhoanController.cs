using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity.UI.V3.Pages.Account.Internal;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class TaiKhoanController : Controller
    {
        private readonly ITaiKhoan TaiKhoan = new TaiKhoanRepository();
        private readonly IHoaDon HoaDon = new HoaDonRepository();
        private readonly ICTHoaDon CTHoaDon = new CTHoaDonRepository();
        // GET: TaiKhoanController
        public ActionResult DSDonHang()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("DangNhap", "TaiKhoan");
            }
            else
            {
                IEnumerable<HoaDonViewModel> model = HoaDon.SelectAll().Select(
                 item => new HoaDonViewModel
                 {
                     Id = item.Id,
                     IsDelete = item.IsDelete,
                     NgayTao = item.NgayTao,
                     TongTien = item.TongTien,
                     IdKh = item.IdKh,
                     TrangThaiDonHang = item.TrangThaiDonHang
                 }).OrderByDescending(x => x.NgayTao).Where(x => x.IdKh == HttpContext.Session.GetInt32("id"));
                return View(model);
            }
        }
        [HttpGet]
        public ActionResult Delete(string IdDelete)
        {
            if (IdDelete != null && IdDelete != "")
            {
                var px = HoaDon.SelectById(Int32.Parse(IdDelete));
                px.TrangThaiDonHang = "Huydon";
                HoaDon.Update(px);
                HoaDon.Save();
            }
            return RedirectToAction("DSDonHang","TaiKhoan");
        }
        // GET: TaiKhoanController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TaiKhoanController/Create
        public ActionResult DangKy()
        {
            return View();
        }

        // POST: TaiKhoanController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangKy(TaiKhoanViewModel model)
        {
            try
            {
                var item = new TaiKhoan();
                item.HoVaTen = model.HoVaTen;
                item.IsAdmin = false;
                item.IsDelete = false;
                item.MatKhau = model.MatKhau;
                item.DiaChi = model.DiaChi;
                item.TenTaiKhoan = model.TenTaiKhoan;
                item.Sdt = model.Sdt;
                item.NgayTao = DateTime.Now;
                item.TongTien = 0;
                TaiKhoan.Insert(item);
                TaiKhoan.Save();
                return RedirectToAction(nameof(DangNhap));
            }
            catch
            {
                return View();
            }
        }

        // GET: TaiKhoanController/Edit/5
        public ActionResult DangNhap()
        {
            return View();
        }

        // POST: TaiKhoanController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DangNhap(string name,string pass)
        {
            var taikhoanlogin = TaiKhoan.Login(name, pass);
            if(taikhoanlogin == null)
            {
                return View();
            }    
            else
            {
                HttpContext.Session.SetString("username", taikhoanlogin.TenTaiKhoan);
                HttpContext.Session.SetString("diachi", taikhoanlogin.DiaChi);
                HttpContext.Session.SetString("sdt", taikhoanlogin.Sdt);
                HttpContext.Session.SetInt32("id", taikhoanlogin.Id);
                return RedirectToAction("Index","Home");
            }    
        }
        [HttpPost]
        public ActionResult DangXuat()
        {
            HttpContext.Session.Remove("username");
            HttpContext.Session.Remove("diachi");
            HttpContext.Session.Remove("sdt");
            HttpContext.Session.Remove("id");
            return RedirectToAction("Index", "Home"); 
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
