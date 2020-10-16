using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class SanPham
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public double? DonGia { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NoiDung { get; set; }
        public string AnhMoTa { get; set; }
        public bool? IsDelete { get; set; }
    }
}
