using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class CtphieuNhap
    {
        public int Id { get; set; }
        public int? IdPn { get; set; }
        public int? IdSp { get; set; }
        public int? IdSize { get; set; }
        public double? DonGia { get; set; }
    }
}
