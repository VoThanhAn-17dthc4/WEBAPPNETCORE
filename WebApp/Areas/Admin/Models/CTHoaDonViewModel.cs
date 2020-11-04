using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class CTHoaDonViewModel
    {
        public int Id { get; set; }
        public int? IdHd { get; set; }
        public int? IdSp { get; set; }
        public int? IdLoaisp { get; set; }
        public int? IdSize { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
    }
}
