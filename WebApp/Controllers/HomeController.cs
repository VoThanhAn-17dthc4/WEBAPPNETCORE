using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<UserIdentity> _userManager;
        private readonly SignInManager<UserIdentity> _signInManager;
        private readonly IGioHang gioHang = new GioHangRepository();
        private readonly ICTGioHang CTGioHang = new CTGioHangRepository();
        private readonly IHoaDon HoaDon = new HoaDonRepository();
        private readonly ICTHoaDon CTHoaDon = new CTHoaDonRepository();
        private readonly ISanpham Sanpham = new SanPhamRepository();
        private readonly ISize Sizex = new SizeRepository();
        private readonly ITaiKhoan TaiKhoan = new TaiKhoanRepository();
        public HomeController(ILogger<HomeController> logger, UserManager<UserIdentity> userManager, SignInManager<UserIdentity> signInManager)
        {
            _logger = logger;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        public IActionResult GioHang()
        {
            if (HttpContext.Session.GetString("username") == null)
            {
                return RedirectToAction("DangNhap", "TaiKhoan");
            }
            else
            {
                var idtk = HttpContext.Session.GetInt32("id");
                var item = gioHang.FindByIdTK(idtk);
                var model = new GioHangViewModel();
                if (item != null)
                {
                    model.Id = item.Id;
                    model.IdTk = item.IdTk;
                    model.TongTien = item.TongTien;
                    var details = CTGioHang.SelectAll().Select(item => new CTGioHangViewModel
                    {
                        IdSp = item.IdSp,
                        Id = item.Id,
                        IdGh = item.IdGh,
                        IdSize = item.IdSize,
                        SoLuong = item.SoLuong,
                        DonGia = item.DonGia,
                        SLToiDa = Sizex.sltoida(item.IdSp,item.IdSize)
                    }).Where(x => x.IdGh == item.Id).ToList();
                    model.CTGioHangViewModel = details;
                    return View(model);
                }
                else
                {
                    return View(model);
                }    
               
            }    
        }
        public IActionResult ThanhToan(string diachi, string sdt)
        {
            var idtk = HttpContext.Session.GetInt32("id");
            var item = gioHang.FindByIdTK(idtk);
            var model = new GioHangViewModel();
            model.Id = item.Id;
            model.IdTk = item.IdTk;
            model.TongTien = item.TongTien;
            var details = CTGioHang.SelectAll().Select(item => new CTGioHangViewModel
            {
                IdSp = item.IdSp,
                Id = item.Id,
                IdGh = item.IdGh,
                IdSize = item.IdSize,
                SoLuong = item.SoLuong,
                DonGia = item.DonGia
            }).Where(x => x.IdGh == item.Id).ToList();
            model.CTGioHangViewModel = details;
            var hoadon = new HoaDon();
            hoadon.IdKh = idtk;
            hoadon.IsDelete = false;
            hoadon.NgayTao = DateTime.Now;
            hoadon.SDT = sdt;
            hoadon.DiaChi = diachi;
            hoadon.TongTien = item.TongTien;
            hoadon.TrangThaiDonHang = "Chuaduyet";
            HoaDon.Insert(hoadon);
            HoaDon.Save();
            foreach (var del in details)
            {
                var cthd = new CthoaDon();
                cthd.IdHd = hoadon.Id;
                cthd.IdLoaisp = 1;
                cthd.IdSize = del.IdSize;
                cthd.IdSp = del.IdSp;
                cthd.SoLuong = del.SoLuong;
                cthd.DonGia = del.DonGia;
                CTHoaDon.Insert(cthd);
                CTHoaDon.Save();
            }
            gioHang.Delete(item.Id);
            gioHang.Save();
            foreach (var del in details)
            {
                CTGioHang.Delete(del.Id);
                CTGioHang.Save();
            }
            return RedirectToAction(nameof(GioHang));
        }
        public IActionResult UpdateSL(GioHangViewModel model)
        {
            foreach(var item in model.CTGioHangViewModel)
            {
                var x = CTGioHang.SelectById(item.Id);
                x.SoLuong = item.SoLuong;
               
                var sp = Sizex.findbysizeandid(x.IdSp, x.IdSize);
                if (sp.SoLuongKho >= item.SoLuong)
                {
                    CTGioHang.Update(x);
                    CTGioHang.Save();
                    var ctgh = CTGioHang.SelectAll();
                    double? tongtien = 0;
                    foreach(var item1 in ctgh)
                    {
                        tongtien += item1.SoLuong * item1.DonGia;
                    }
                    var gh = gioHang.SelectById(item.IdGh);
                    gh.TongTien = tongtien;
                    gioHang.Update(gh);
                    gioHang.Save();
                }  
            }
            return RedirectToAction("GioHang","Home");
        }
        public IActionResult DeleteSP(int? Id)
        {
            CTGioHang.Delete(Id);
            CTGioHang.Save();
            return RedirectToAction("GioHang", "Home");
        }
        public IActionResult Index()
        {
            IEnumerable<SanPhamViewModel> spmoi = Sanpham.SelectAll().Select(
                     item => new SanPhamViewModel
                     {
                         Id = item.Id,
                         Ten = item.Ten,
                         NgayTao = item.NgayTao,
                         AnhMoTa = item.AnhMoTa,
                         DonGia = item.DonGia,
                         NoiDung = item.NoiDung,
                         IsDelete = item.IsDelete,
                         IdLoai = item.IdLoai
                     }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true).Take(4);
            IEnumerable<SanPhamViewModel> model = Sanpham.SelectAll().Select(
                   item => new SanPhamViewModel
                   {
                       Id = item.Id,
                       Ten = item.Ten,
                       NgayTao = item.NgayTao,
                       AnhMoTa = item.AnhMoTa,
                       DonGia = item.DonGia,
                       NoiDung = item.NoiDung,
                       IsDelete = item.IsDelete,
                       IdLoai = item.IdLoai
                   }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true);
            ViewBag.spmoi = spmoi;
            ViewBag.model = model;
            return View();
        }
        [HttpGet]
        [AllowAnonymous]
        public IActionResult Login([FromRoute] string returnUrl = "")
        {
            var model = new LoginViewModel { ReturnUrl = returnUrl };
            return View(model);
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model, [FromRoute] string returnUrl = null)
        {
            try
            {
                ViewData["ReturnUrl"] = returnUrl;
                if (ModelState.IsValid)
                {
                    var result = await _signInManager.PasswordSignInAsync(model.Email, model.Password, model.RememberMe, lockoutOnFailure: false);
                    if (result.Succeeded)
                    {
                        if(TaiKhoan.checkisdelete(model.Email) == true)
                        {
                            ModelState.AddModelError(string.Empty, "Tai khoan hoac mat khau khong dung!!!.");
                            return View(model);
                        }
                        if (TaiKhoan.checkisdelete(model.Email) == false)
                        {
                            HttpContext.Session.SetString("nameadmin",model.Email);
                            return RedirectToAction("Index", "SanPhams", new { Area = "Admin" });
                        }
                        HttpContext.Session.SetString("nameadmin", model.Email);
                        return RedirectToAction(returnUrl);
                    }
                    if (result.IsLockedOut)
                    {
                        _logger.LogWarning(2, "User account locked out.");
                        return View("Lockout");
                    }
                    else
                    {
                        ModelState.AddModelError(string.Empty, "Tai khoan hoac mat khau khong dung!!!.");
                        return View(model);
                    }
                }
            }
            catch(Exception e)
            {
            }
            // If we got this far, something failed, redisplay form
            return View(model);
        }
        public IActionResult Privacy()
        {
            return View();
        }
        

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
