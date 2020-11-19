using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class PhieuNhapController : Controller
    {
        private readonly IPhieuNhap PhieuNhap = new PhieuNhapRepository();
        private readonly ICTPhieuNhap CTPhieuNhap = new CTPhieuNhapRepository();
        private readonly ISize Size = new SizeRepository();
        public IActionResult Index(string id)
        {
            IEnumerable<PhieuNhapViewModel> model = PhieuNhap.SelectAll().Select(
                item => new PhieuNhapViewModel
                {
                    Id = item.Id,
                    IdNcc = item.IdNcc,
                    IdTk = item.IdTk,
                    IsDelete = item.IsDelete,
                    NgayTao = item.NgayTao,
                    TongTien = item.TongTien,
                    TieuDe = item.TieuDe
                }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true);
            if (id != null)
            {
                model = model.Where(x => x.Id.ToString().Contains(id.ToString())).ToList();
            }
            return View(model);
        }
        public IActionResult Details(int? id)
        {
            var model = new PhieuNhapViewModel();
            var item = PhieuNhap.SelectById(id);
            model.Id = item.Id;
            model.TieuDe = item.TieuDe;
            model.TongTien = item.TongTien;
            model.IdNcc = item.IdNcc;
            model.IdTk = item.IdTk ;
            model.IsDelete = item.IsDelete;
            model.NgayTao = item.NgayTao;
            var details = CTPhieuNhap.SelectAll().Select(item => new CTPhieuNhapViewModel
            {
                IdSp = item.IdSp,
                IdPn = item.IdPn,
                IdSize = item.IdSize,
                SoLuong = item.SoLuong,
                DonGia = item.DonGia
            }).Where(x => x.IdPn == id).ToList();
            model.CTPhieuNhapViewModel = details;
            return View(model);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(PhieuNhapViewModel model)
        {
            try
            {
                var phieunhap = new PhieuNhap();
                phieunhap.IdNcc = model.IdNcc;
                phieunhap.IdTk = 1;
                phieunhap.IsDelete = false;
                phieunhap.NgayTao = DateTime.Now;
                phieunhap.TieuDe = model.TieuDe;
                phieunhap.TongTien = model.TongTien;
                PhieuNhap.Insert(phieunhap);
                PhieuNhap.Save();
                var idpn = phieunhap.Id;
                foreach (var item in model.CTPhieuNhapViewModel)
                {
                    var ctpn = new CtphieuNhap();
                    ctpn.IdPn = idpn;
                    ctpn.IdSize = item.IdSize;
                    ctpn.IdSp = item.IdSp;
                    ctpn.SoLuong = item.SoLuong;
                    ctpn.DonGia = item.DonGia;
                    CTPhieuNhap.Insert(ctpn);
                    CTPhieuNhap.Save();
                    var ctsp = Size.findbysizeandid(item.IdSp, item.IdSize);
                    ctsp.SoLuongKho = ctsp.SoLuongKho + item.SoLuong;
                    Size.Update(ctsp);
                    Size.Save();
                }
            }
            catch(Exception e)
            {

            }
            return View();
        }
    }
}
