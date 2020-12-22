using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Text.RegularExpressions;
using WebApp.Areas.Admin.Models;
using WebApp.Interface;
using WebApp.Models;
using WebApp.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
namespace WebApp.Helper
{
    
    public static class Comon
    {
        private static ISanpham Sanpham = new SanPhamRepository();
        private static ILoaiSP LoaiSP = new LoaiSPRepository();
        private static ITaiKhoan TaiKhoan = new TaiKhoanRepository();
        private static readonly UserManager<UserIdentity> _userManager;

        public static DateTime GetFistDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);
            return aDateTime;
        }

        // Trả về ngày cuối cùng của tháng.
        public static DateTime GetLastDayInMonth(int year, int month)
        {
            DateTime aDateTime = new DateTime(year, month, 1);

            // Cộng thêm 1 tháng và trừ đi một ngày.
            DateTime retDateTime = aDateTime.AddMonths(1).AddDays(-1);

            return retDateTime;
        }
        public static string ChuyenThanhKhongDau(string s)
        {
            if (string.IsNullOrEmpty(s) == true)
                return "";

            Regex regex = new Regex("\\p{IsCombiningDiacriticalMarks}+");
            string temp = s.Normalize(NormalizationForm.FormD);
            return regex.Replace(temp, String.Empty).Replace('\u0111', 'd').Replace('\u0110', 'D').ToLower();
        }
        ////////////->>>>>>Display tên từ id
        public static string NameByIdSP(int? id)
        {
            var model = Sanpham.SelectById(id);
            var name = model.Ten;
            return name;
        }
        public static string NameByIdLoaiSP(int? id)
        {
            var model = LoaiSP.SelectById(id);
            var name = model.Ten;
            return name;
        }
        public static string ImgByIdSP(int? id)
        {
            var model = Sanpham.SelectById(id);
            var name = model.AnhMoTa;
            return name;
        }
        public static string NameByIdTK(int? id)
        {
            var model = TaiKhoan.SelectById(id);
            var name = model.HoVaTen;
            return name;
        }
        public static int? IdByNameTK(string names)
        {
            var model = TaiKhoan.Namebyid(names);
            return model;
        }
        public static IEnumerable<LoaiSPViewModel> loaisp()
        {
            IEnumerable<LoaiSPViewModel> model = LoaiSP.SelectAll().Select(
                item => new LoaiSPViewModel
                {
                    Id = item.Id,
                    Ten = item.Ten,
                    IsDelete = item.IsDelete
                });
            return model;
        }
    }
}
