using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class CtgioHang
    {
        public int Id { get; set; }
        public int? IdGh { get; set; }
        public int? IdSp { get; set; }
        public int? IdSize { get; set; }
        public int? SoLuong { get; set; }
        public double? DonGia { get; set; }
    }
}
