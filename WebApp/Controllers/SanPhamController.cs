using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPhamController
        private readonly ISanpham Sanpham = new SanPhamRepository();
        private readonly ISize Size = new SizeRepository();
        private readonly ICTSanPham CTSanpham = new CTSanPhamRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DSSanPham()
        {
            IEnumerable<SanPhamViewModel> model = Sanpham.SelectAll().Select(
                     item => new SanPhamViewModel
                     {
                         Id = item.Id,
                         Ten = item.Ten,
                         NgayTao = item.NgayTao,
                         AnhMoTa = item.AnhMoTa,
                         DonGia = item.DonGia,
                         NoiDung = item.NoiDung,
                         IsDelete = item.IsDelete
                     }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true);
            return View(model);
        }

        // GET: SanPhamController/Details/5
        public ActionResult ChiTietSP(int id)
        {
            var model = new SanPhamViewModel();
            var item = Sanpham.SelectById(id);
            model.Id = item.Id;
            model.Ten = item.Ten;
            model.NgayTao = item.NgayTao;
            model.AnhMoTa = item.AnhMoTa;
            model.DonGia = item.DonGia;
            model.NoiDung = item.NoiDung;
            model.IsDelete = item.IsDelete;
            var details = Size.SelectAll().Select(item => new SizeViewModel
            {
                IdSp = item.IdSp,
                SizeNumber = item.SizeNumber,
                SoLuongKho = item.SoLuongKho,
                IsDelete = false
            }).Where(x => x.IdSp == id).ToList();
            model.SizeViewModel = details;
            return View(model);
        }

        // GET: SanPhamController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SanPhamController/Create
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

        // GET: SanPhamController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SanPhamController/Edit/5
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

        // GET: SanPhamController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SanPhamController/Delete/5
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
