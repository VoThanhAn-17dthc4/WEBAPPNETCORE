using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class TaiKhoan
    {
        public int Id { get; set; }
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public DateTime? NgayTao { get; set; }
        public string HoVaTen { get; set; }
        public string Sdt { get; set; }
        public double? TongTien { get; set; }
        public bool? IsAdmin { get; set; }
        public bool? IsDelete { get; set; }
        public string DiaChi { get; set; }
    }
}
