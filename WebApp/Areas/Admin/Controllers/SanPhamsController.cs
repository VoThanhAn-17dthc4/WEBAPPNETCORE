using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;
using System.IO;
using Microsoft.Extensions.Hosting.Internal;
using Microsoft.AspNetCore.Hosting;
using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class SanPhamsController : Controller
    {
        private readonly WebAppBanHangContext _context;
        private readonly ISanpham Sanpham = new SanPhamRepository();
        private readonly ISize Size = new SizeRepository();
        private readonly ICTSanPham CTSanpham = new CTSanPhamRepository();
        private readonly IWebHostEnvironment webHostEnvironment;
        public SanPhamsController(WebAppBanHangContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            webHostEnvironment = hostEnvironment;
        }

        // GET: Admin/SanPhams
        public async Task<IActionResult> Index()
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
                     }).OrderByDescending(x => x.NgayTao).Where(x=>x.IsDelete!=true);
            return View(model);
        }

        // GET: Admin/SanPhams/Details/5
        public async Task<IActionResult> Details(int? id)
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

        // GET: Admin/SanPhams/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Admin/SanPhams/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(SanPhamViewModel model)
        {
            try
            {
                var img = UploadedFile(model);
                var _sp = new SanPham();
                _sp.Ten = model.Ten;
                _sp.NoiDung = model.NoiDung;
                _sp.IsDelete = false;
                _sp.NgayTao = DateTime.Now;
                _sp.AnhMoTa = img;
                _sp.DonGia = model.DonGia;
                Sanpham.Insert(_sp);
                Sanpham.Save();
                var idsp = _sp.Id;
                foreach (var item in model.SizeViewModel)
                {
                    var _size = new Size();
                    _size.IdSp = idsp;
                    _size.SizeNumber = item.SizeNumber;
                    _size.SoLuongKho = item.SoLuongKho;
                    _size.IsDelete = false;
                    Size.Insert(_size);
                    Size.Save();
                }
            }
            catch(Exception e)
            {

            }
            return View();
        }
        private string UploadedFile(SanPhamViewModel model)
        {
            string uniqueFileName = null;

            if (model.ProfileImage != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "imageproducts");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ProfileImage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ProfileImage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        // GET: Admin/SanPhams/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var sanPham = await _context.SanPham.FindAsync(id);
            if (sanPham == null)
            {
                return NotFound();
            }
            return View(sanPham);
        }

        // POST: Admin/SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Ten,DonGia,NgayTao,NoiDung,AnhMoTa,SoLuongKho,IsDelete")] SanPham sanPham)
        {
            if (id != sanPham.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(sanPham);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SanPhamExists(sanPham.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(sanPham);
        }

        // GET: Admin/SanPhams/Delete/5
        public async Task<IActionResult> Delete(string IdDelete)
        {
            var tp = Sanpham.SelectById(int.Parse(IdDelete));
            if (tp != null)
            {
                tp.IsDelete = true;
                Sanpham.Update(tp);
                Sanpham.Save();
                return RedirectToAction("Index");
            }
            return View();
        }

        // POST: Admin/SanPhams/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string IdDelete)
        {
            var tp = Sanpham.SelectById(int.Parse(IdDelete));
            if (tp != null)
            {
                tp.IsDelete = true;
                Sanpham.Update(tp);
                Sanpham.Save();
                return RedirectToAction("Index");
            };
            return RedirectToAction(nameof(Index));
        }

        private bool SanPhamExists(int id)
        {
            return _context.SanPham.Any(e => e.Id == id);
        }
    }
}
