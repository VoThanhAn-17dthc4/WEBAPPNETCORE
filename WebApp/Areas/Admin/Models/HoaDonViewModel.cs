using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class HoaDonViewModel
    {
        public int Id { get; set; }
        public DateTime? NgayTao { get; set; }
        public double? TongTien { get; set; }
        public int? IdKh { get; set; }
        public bool? IsDelete { get; set; }
        public string TrangThaiDonHang { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public List<CTHoaDonViewModel> CTHoaDonViewModel { set; get; }
    }
}
