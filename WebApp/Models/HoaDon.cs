using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class HoaDon
    {
        public int Id { get; set; }
        public DateTime? NgayTao { get; set; }
        public double? TongTien { get; set; }
        public int? IdKh { get; set; }
        public bool? IsDelete { get; set; }
        public string TrangThaiDonHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
    }
}
