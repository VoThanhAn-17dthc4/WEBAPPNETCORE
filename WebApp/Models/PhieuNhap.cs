using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class PhieuNhap
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public DateTime? NgayTao { get; set; }
        public double? TongTien { get; set; }
        public int? IdTk { get; set; }
        public int? IdNcc { get; set; }
        public bool? IsDelete { get; set; }
    }
}
