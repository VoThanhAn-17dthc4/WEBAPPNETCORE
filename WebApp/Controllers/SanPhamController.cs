using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin.Models;
using WebApp.Helper;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPhamController
        private readonly ISanpham Sanpham = new SanPhamRepository();
        private readonly ISize Sizex = new SizeRepository();
        private readonly ICTSanPham CTSanpham = new CTSanPhamRepository();
        private readonly ICTGioHang CTGioHang = new CTGioHangRepository();
        private readonly IGioHang GioHang = new GioHangRepository();
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult DSSanPham(string name,string id,string gia1,string gia2)
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
                         IsDelete = item.IsDelete,
                         IdLoai = item.IdLoai
                     }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true);
            if(gia1!=null && gia2 != null)
            {
                model = model.Where(x => x.DonGia >= int.Parse(gia1) && x.DonGia <= int.Parse(gia2));
            }    
            if(id != null)
            {
                model = model.Where(x => x.IdLoai == int.Parse(id));
            }    
            if(name != null)
            {
                model = model.Where(x => Comon.ChuyenThanhKhongDau(x.Ten).Contains(Comon.ChuyenThanhKhongDau(name)));
            }    
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
            var details = Sizex.SelectAll().Select(item => new SizeViewModel
            {
                IdSp = item.IdSp,
                SizeNumber = item.SizeNumber,
                SoLuongKho = item.SoLuongKho,
                IsDelete = false
            }).Where(x => x.IdSp == id).ToList();
            model.SizeViewModel = details;
            IEnumerable<SanPhamViewModel> splienquan = Sanpham.SelectAll().Select(
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
                     }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true && x.IdLoai == item.IdLoai).Take(6);
            ViewBag.spliequan = splienquan;
            return View(model);
        }
        [HttpGet]
        // GET: SanPhamController/Create
        public ActionResult AddProductsToCart(int? Id,int? Sl,int? Size,double? DonGia)
        {
            var idtk = HttpContext.Session.GetInt32("id");
            if(idtk != null)
            {
                var sp = Sizex.findbysizeandid(Id, Size);
                if(sp.SoLuongKho >= Sl)
                {
                    var kq = GioHang.FindByIdTK(idtk);
                    if (kq == null)
                    {
                        var item = new Giohang();
                        item.IdTk = idtk;
                        item.TongTien = Sl*DonGia;
                        GioHang.Insert(item);
                        GioHang.Save();
                        var itemx = new CtgioHang();
                        itemx.IdGh = item.Id;
                        itemx.IdSize = Size;
                        itemx.IdSp = Id;
                        itemx.SoLuong = Sl;
                        itemx.DonGia = DonGia;
                        CTGioHang.Insert(itemx);
                        CTGioHang.Save();
                    }
                    else
                    {
                        var ctgh = CTGioHang.FindByIdSP(Size, Id, kq.Id);
                        if (ctgh == null)
                        {
                            var itemx = new CtgioHang();
                            itemx.IdGh = kq.Id;
                            itemx.IdSize = Size;
                            itemx.IdSp = Id;
                            itemx.SoLuong = Sl;
                            itemx.DonGia = DonGia;
                            CTGioHang.Insert(itemx);
                            CTGioHang.Save();
                        }
                        else
                        {
                            kq.TongTien = kq.TongTien + (Sl * DonGia);
                            GioHang.Update(kq);
                            GioHang.Save();
                            var ctghx = CTGioHang.FindByIdSP(Size, Id, kq.Id);
                            ctghx.SoLuong += Sl;
                            CTGioHang.Update(ctghx);
                            CTGioHang.Save();
                        }
                    }
                    sp.SoLuongKho = sp.SoLuongKho - Sl;
                    Sizex.Update(sp);
                    Sizex.Save();
                    return Json("ok");
                }    
                else
                {
                    return Json(sp.SoLuongKho.ToString());
                }    
            }
            return RedirectToAction("DangNhap", "TaiKhoan");
        }

    }
}
