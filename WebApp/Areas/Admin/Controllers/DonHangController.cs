using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class DonHangController : Controller
    {
        private readonly IHoaDon HoaDon = new HoaDonRepository();
        private readonly ICTHoaDon CTHoaDon = new CTHoaDonRepository();
        // GET: DonHangController
        public async Task<IActionResult> Index()
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
                  }).OrderByDescending(x => x.NgayTao);
            return View(model);
        }

        // GET: DonHangController/Details/5
        public ActionResult Details(int id)
        {
            var model = new HoaDonViewModel();
            var item = HoaDon.SelectById(id);
            model.Id = item.Id;
            model.IsDelete = item.IsDelete;
            model.NgayTao = item.NgayTao;
            model.TongTien = item.TongTien;
            model.IdKh = item.IdKh;
            model.TrangThaiDonHang = item.TrangThaiDonHang;
            var details = CTHoaDon.SelectAll().Select(item => new CTHoaDonViewModel
            {
                IdSp = item.IdSp,
                SoLuong = item.SoLuong,
                IdHd = item.IdHd,
                DonGia = item.DonGia,
                IdLoaisp = item.IdLoaisp,
                IdSize = item.IdSize,
                Id = item.Id
            }).Where(x => x.IdHd == id).ToList();
            model.CTHoaDonViewModel = details;
            return View(model);
        }

        // GET: DonHangController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: DonHangController/Create
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

        // GET: DonHangController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: DonHangController/Edit/5
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

        // GET: DonHangController/Delete/5
        public ActionResult Delete(string IdDelete)
        {
            if (IdDelete != null && IdDelete != "")
            {
                var px = HoaDon.SelectById(Int32.Parse(IdDelete));
                px.TrangThaiDonHang = "Huydon";
                HoaDon.Update(px);
                HoaDon.Save();
            }
            return RedirectToAction("Index");
        }
        public IActionResult UpdateStatus(string Submit)
        {
            if (Submit != null)
            {
                var px = HoaDon.SelectById(int.Parse(Submit));
                if (px.TrangThaiDonHang == "Chuaduyet")
                {
                    px.TrangThaiDonHang = "Danggiao";
                    HoaDon.Update(px);
                    HoaDon.Save();
                    return RedirectToAction("Details", "DonHang", new { id = int.Parse(Submit) });
                }
                if (px.TrangThaiDonHang == "Danggiao")
                {
                    px.TrangThaiDonHang = "Hoanthanh";
                    HoaDon.Update(px);
                    HoaDon.Save();
                    return RedirectToAction("Details", "DonHang", new { id = int.Parse(Submit) });
                }
            }
            return View();
        }
    }
}
