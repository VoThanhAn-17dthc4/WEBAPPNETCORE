using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Repository;

namespace WebApp.Helper
{
    
    public static class Comon
    {
        private static ISanpham Sanpham = new SanPhamRepository();

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
    }
}
