using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Interface;
using WebApp.Repository;
using WebApp.Areas.Admin.Models;
using WebApp.Models;
using Microsoft.AspNetCore.Authorization;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class LoaiSPController : Controller
    {
        private readonly ILoaiSP LoaiSP = new LoaiSPRepository();
        // GET: LoaiSPController
        public ActionResult Index(string txtInfo)
        {
            IEnumerable<LoaiSPViewModel> model = LoaiSP.SelectAll().Select(
                  item => new LoaiSPViewModel
                  {
                      Id = item.Id,
                      Ten = item.Ten,
                      IsDelete = item.IsDelete,
                  });
            if(txtInfo != null)
            {
                model = model.Where(x => Helper.Comon.ChuyenThanhKhongDau(x.Ten).Contains(Helper.Comon.ChuyenThanhKhongDau(txtInfo)));
            }    
            return View(model);
        }
        // GET: LoaiSPController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LoaiSPController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LoaiSPViewModel model)
        {
            try
            {
                var item = new LoaiSp();
                item.Ten = model.Ten;
                item.IsDelete = false;
                LoaiSP.Insert(item);
                LoaiSP.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoaiSPController/Edit/5
        public ActionResult Edit(int id)
        {
            var item = LoaiSP.SelectById(id);
            var model = new LoaiSPViewModel();
            model.Id = item.Id;
            model.IsDelete = item.IsDelete;
            model.Ten = item.Ten;
            return View(model);
        }

        // POST: LoaiSPController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(LoaiSPViewModel model)
        {
            try
            {
                var item = LoaiSP.SelectById(model.Id);
                item.Ten = model.Ten;
                LoaiSP.Update(item);
                LoaiSP.Save();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LoaiSPController/Delete/5
        public ActionResult Delete(string IdDelete)
        {
            var item = LoaiSP.SelectById(int.Parse(IdDelete));
            item.IsDelete = true;
            LoaiSP.Update(item);
            LoaiSP.Save();
            return View();
        }
        
    }
}
