using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;
using WebApp.Helper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class NhaCungCapController : Controller
    {
        private readonly UserManager<UserIdentity> _userManager;
        private readonly WebAppBanHangContext _context;
        private readonly INhaCungCap NhaCungCap = new NhaCungCapRepository();
        
        private readonly IWebHostEnvironment webHostEnvironment;
        private object _sp;
        private object _NhaCungCap;

        public NhaCungCapController(IWebHostEnvironment _webHostEnvironment)
        {
            webHostEnvironment = _webHostEnvironment;
        }
        public async Task <IActionResult> Index()
        {
            IEnumerable<NhaCungCapViewModel> model = NhaCungCap.SelectAll().Select(
                    item => new NhaCungCapViewModel
                    {
                        Id = item.Id,
                        Ten = item.Ten,
                        NgayTao = item.NgayTao,
                        IsDelete = item.IsDelete
                    }).OrderByDescending(x => x.NgayTao).Where(x => x.IsDelete != true);
            return View(model);
        }
        public IActionResult Create()
        {
            //cái này là get
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NhaCungCapViewModel model)// => nhận dữ liệu từ view)
        {
            //cái này là post
            try
            {

                var _ncc = new NhaCungCap();
                _ncc.Ten = model.Ten;
                _ncc.IsDelete = false;
                _ncc.NgayTao = DateTime.Now;
                var idncc = _NhaCungCap.id;
                return RedirectToAction("Index", "NhaCungCaps");
            }
            catch (Exception e)
            {

            }
            return View();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            var model = new NhaCungCapViewModel();
            var item = NhaCungCap.SelectById(id);
            model.Id = item.Id;
            model.Ten = item.Ten;
            model.NgayTao = item.NgayTao;
            model.IsDelete = item.IsDelete;
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(NhaCungCapViewModel model)
        {
            try
            {
                var _ncc = NhaCungCap.SelectById(model.Id);
                
                _ncc.Ten = model.Ten;
                NhaCungCap.Update(_ncc);
                NhaCungCap.Save();
            }  
              return View();
        }
     }
}
