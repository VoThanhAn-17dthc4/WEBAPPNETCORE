using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class PhieuNhapViewModel
    {
        public int Id { get; set; }
        public string TieuDe { get; set; }
        public DateTime? NgayTao { get; set; }
        public double? TongTien { get; set; }
        public int? IdTk { get; set; }
        public int? IdNcc { get; set; }
        public bool? IsDelete { get; set; }
        public List<CTPhieuNhapViewModel> CTPhieuNhapViewModel { get; set; }
    }
}
