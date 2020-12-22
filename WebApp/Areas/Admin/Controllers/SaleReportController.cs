using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp.Helper;
using WebApp.Models;

namespace WebApp.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class SaleReportController : Controller
    {
        WebAppBanHangContext _db = new WebAppBanHangContext();

        public IActionResult DoanhThuTheoThang(string s_year)
        {
            List<SelectListItem> Year = new List<SelectListItem>();
            DateTime d_year;
            double? tongtien = 0;
            var year = DateTime.Now.Year;
            for (int i = year - 3; i <= year + 3; i++)
            {
                Year.Add(new SelectListItem { Text = i.ToString(), Value = i.ToString() });
            }
            var model = _db.DoanhThuTheoTungThang.FromSqlRaw("Execute dbo.DoanhThuTheoThang @year = {0} ", year);
            if (s_year != null && s_year != "")
            {
                model = _db.DoanhThuTheoTungThang.FromSqlRaw("Execute dbo.DoanhThuTheoThang @year = {0} ", s_year);
                year = Int32.Parse(s_year);
            }
            foreach (var item in model)
            {
                tongtien += item.Loinhuan;
            }
            ViewBag.year = Year.ToList();
            ViewBag.isyear = year.ToString();
            ViewBag.tongtien = tongtien;
            return View(model);
        }
        public IActionResult SPBanChay(string startDate, string endDate)
        {
            var aDateTime = Comon.GetFistDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            var retDateTime = Comon.GetLastDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            if (startDate == null && endDate == null)
            {
                startDate = aDateTime.ToString("dd/MM/yyyy");
                endDate = retDateTime.ToString("dd/MM/yyyy");
            }
            DateTime d_startDate, d_endDate;
            if (DateTime.TryParseExact(startDate, "dd/MM/yyyy", new CultureInfo("vi-VN"), DateTimeStyles.None, out d_startDate))
            {
                if (DateTime.TryParseExact(endDate, "dd/MM/yyyy", new CultureInfo("vi-VN"), DateTimeStyles.None, out d_endDate))
                {
                    var user = _db.TopSanPhamBanChay.FromSqlRaw("Execute dbo.topspbanchay @batdau={0}, @ketthuc={1} ", d_startDate, d_endDate);
                    return View(user);
                }
            }else
            {
                var user = _db.TopSanPhamBanChay.FromSqlRaw("Execute dbo.topspbanchay @batdau={0}, @ketthuc={1} ", startDate, endDate);
                return View(user);
            }    
            return View();
        }
        public IActionResult SPBanCham(string startDate, string endDate)
        {
            var aDateTime = Comon.GetFistDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            var retDateTime = Comon.GetLastDayInMonth(DateTime.Now.Year, DateTime.Now.Month);
            if(startDate == null && endDate == null)
            {
                startDate = aDateTime.ToString("dd/MM/yyyy");
                endDate = retDateTime.ToString("dd/MM/yyyy");
            }    
            DateTime d_startDate, d_endDate;
            if (DateTime.TryParseExact(startDate, "dd/MM/yyyy", new CultureInfo("vi-VN"), DateTimeStyles.None, out d_startDate))
            {
                if (DateTime.TryParseExact(endDate, "dd/MM/yyyy", new CultureInfo("vi-VN"), DateTimeStyles.None, out d_endDate))
                {
                    var user = _db.TopSanPhamBanCham.FromSqlRaw("Execute dbo.topspbancham @batdau={0}, @ketthuc={1} ", d_startDate, d_endDate);
                    return View(user);
                }
            }
            else
            {
                var user = _db.TopSanPhamBanCham.FromSqlRaw("Execute dbo.topspbancham @batdau={0}, @ketthuc={1} ", startDate, endDate);
                return View(user);
            }
            return View();
        }
    }
}
