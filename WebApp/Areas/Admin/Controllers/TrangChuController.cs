using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Interface;
using WebApp.Repository;
using WebApp.Helper;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Authorization;
using WebApp.Models;
using WebApp.Areas.Admin.Models;
using Microsoft.EntityFrameworkCore;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class TrangChuController : Controller
    {
        WebAppBanHangContext _db = new WebAppBanHangContext();
        private readonly IPhieuNhap PhieuNhap = new PhieuNhapRepository();
        private readonly ICTPhieuNhap CTPhieuNhap = new CTPhieuNhapRepository();
        private readonly ISize Size = new SizeRepository();
        private readonly IHoaDon HoaDons = new HoaDonRepository();
        private readonly ICTHoaDon CTHoaDon = new CTHoaDonRepository();
        private readonly ISanpham Sanpham = new SanPhamRepository();
        // GET: TrangChuController
        public ActionResult Index()
        {
            double? tongtienthu = 0;
            double? tongtienchi = 0;
            double? tongtienthuhn = 0;
            double? tongtienchihn = 0;
            var aDateTime = Comon.GetFistDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            var retDateTime = Comon.GetLastDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            var startDate = Convert.ToDateTime(aDateTime.ToString("yyyy/MM/dd"));
            var endDate = Convert.ToDateTime(retDateTime.ToString("yyyy/MM/dd"));
            var datenow = Convert.ToDateTime(DateTime.Now.ToString("yyyy/MM/dd"));
            var tongthuhn = HoaDons.SelectAll().Where(x => x.NgayTao >= datenow && x.TrangThaiDonHang == "Hoanthanh");
            foreach (var item in tongthuhn)
            {
                tongtienthuhn += item.TongTien;
            }
            var tongchihn = PhieuNhap.SelectAll().Where(x => x.NgayTao >= datenow);
            foreach (var item in tongchihn)
            {
                tongtienchihn += item.TongTien;
            }
            var tongthu = HoaDons.SelectAll().Where(x => x.NgayTao >= aDateTime && x.NgayTao <= retDateTime && x.TrangThaiDonHang == "Hoanthanh");

            foreach (var item in tongthu)
            {
                tongtienthu += item.TongTien;
            }
            var tongchi = PhieuNhap.SelectAll().Where(x => x.NgayTao >= aDateTime && x.NgayTao <= retDateTime);
            foreach (var item in tongchi)
            {
                tongtienchi += item.TongTien;
            }
            ViewBag.tongdonhang = HoaDons.SelectAll().Where(x => x.NgayTao >= aDateTime && x.NgayTao <= retDateTime || x.NgayTao >= datenow && x.TrangThaiDonHang == "Hoanthanh").Count();
            ViewBag.countHangCon = Size.SelectAll().Where(x => x.SoLuongKho > 0).Count();
            ViewBag.tonghang = Size.SelectAll().Count();
            ViewBag.tongthu = tongtienthu;
            ViewBag.tongchi = tongtienchi;
            ViewBag.tongthuhn = tongtienthuhn;
            ViewBag.tongchihn = tongtienchihn;
            ViewBag.thuchi = tongtienthuhn - tongtienchihn;
            ViewBag.countSapHetHang = Size.SelectAll().Where(x => x.SoLuongKho >= 1 && x.SoLuongKho <= 5).Count();
            ViewBag.countHetHang = Size.SelectAll().Where(x => x.SoLuongKho == 0).Count();
            return View();
        }
        public ActionResult BarchatReal()
        {
            var year = DateTime.Now.Year;
            var user = _db.DTTT.FromSqlRaw("Execute dbo.DoanhThuTheoThang1 @year = {0} ", year);
            return Json(user);
        }
        // GET: TrangChuController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TrangChuController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TrangChuController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: TrangChuController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TrangChuController/Edit/5
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

        // GET: TrangChuController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TrangChuController/Delete/5
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
