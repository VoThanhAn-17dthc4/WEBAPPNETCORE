using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class CTGioHangViewModel
    {
        public int Id { get; set; }
        public int? IdGh { get; set; }
        public int? IdSp { get; set; }
        public int? IdSize { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
        public int? SLToiDa { get; set; }
    }
}
