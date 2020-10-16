using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class CthoaDon
    {
        public int Id { get; set; }
        public int? IdHd { get; set; }
        public int? IdSp { get; set; }
        public int? IdLoaisp { get; set; }
        public int? IdSize { get; set; }
        public double? DonGia { get; set; }
    }
}
