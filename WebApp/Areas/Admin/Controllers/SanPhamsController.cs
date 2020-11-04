using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;
using WebApp.Helper;
using Microsoft.AspNetCore.Identity;

namespace WebApp.Areas.AdminX.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class SanPhamsController : Controller
    {
        private readonly UserManager<UserIdentity> _userManager;
        private readonly WebAppBanHangContext _context;
        private readonly ISanpham Sanpham = new SanPhamRepository();
        private readonly ISize Size = new SizeRepository();
        private readonly ICTSanPham CTSanpham = new CTSanPhamRepository();
        private readonly IWebHostEnvironment webHostEnvironment;
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
                     }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true);
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
            var user = _userManager.FindByNameAsync(User.Identity.Name);
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
            catch (Exception e)
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
                Id = item.Id,
                IdSp = item.IdSp,
                SizeNumber = item.SizeNumber,
                SoLuongKho = item.SoLuongKho,
                IsDelete = false
            }).Where(x => x.IdSp == id).ToList();
            model.SizeViewModel = details;
            return View(model);
        }

        // POST: Admin/SanPhams/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(SanPhamViewModel model)
        {
            try
            {
                var _sp = Sanpham.SelectById(model.Id);
                if (model.AnhMoTa != null)
                {
                    var img = UploadedFile(model);
                    _sp.AnhMoTa = img;
                }
                _sp.Ten = model.Ten;
                _sp.NoiDung = model.NoiDung;              
                _sp.DonGia = model.DonGia;
                Sanpham.Update(_sp);
                Sanpham.Save();
                var idsp = _sp.Id;
                foreach (var item in model.SizeViewModel)
                {
                    var _size = Size.SelectById(item.Id);
                    if(_size == null)
                    {
                        var xsize = new Size();
                        xsize.IdSp = idsp;
                        xsize.SizeNumber = item.SizeNumber;
                        xsize.SoLuongKho = item.SoLuongKho;
                        xsize.IsDelete = false;
                        Size.Insert(xsize);
                        Size.Save();
                    }
                    else
                    {
                        _size.IdSp = idsp;
                        _size.SizeNumber = item.SizeNumber;
                        _size.SoLuongKho = item.SoLuongKho;
                        Size.Update(_size);
                        Size.Save();
                    }    
                   
                }
            }
            catch (Exception e)
            {

            }
            return View();
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
        public JsonResult FindProdcuts(string name,int? loai)
        {
            var products = Sanpham.SelectAll();
            var size = Size.SelectAll();
            var ketqua = from product in products
                         from sizes in size
                         where Comon.ChuyenThanhKhongDau(product.Ten).Contains(Comon.ChuyenThanhKhongDau(name)) && product.Id == sizes.IdSp
                         select new
                         {
                             ten = product.Ten,
                             donGia = product.DonGia,
                             anhMoTa = product.AnhMoTa,
                             size = sizes.SizeNumber,
                             id = product.Id
                         };
            return Json(ketqua);
        }
        public JsonResult FindProdcutsById(int? id,int? size)
        {
            var products = Sanpham.SelectAll();
            var sizex = Size.SelectAll();
            var ketqua = from product in products
                         from sizes in sizex
                         where product.Id == id && product.Id == sizes.IdSp && sizes.SizeNumber == size
                         select new
                         {
                             ten = product.Ten,
                             donGia = product.DonGia,
                             sizeid = sizes.SizeNumber.ToString()+product.Id.ToString()
                         };
            return Json(ketqua);
        }
        public JsonResult DeleteSizeById(int? Id)
        {
            Size.Delete(Id);
            Size.Save();
            return Json("ok");
        }
    }
}