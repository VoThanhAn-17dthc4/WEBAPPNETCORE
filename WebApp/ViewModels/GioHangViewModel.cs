using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.ViewModels
{
    public class GioHangViewModel
    {
        public int Id { get; set; }
        public int? IdTk { get; set; }
        public double? TongTien { get; set; }
        public List<CTGioHangViewModel> CTGioHangViewModel { get; set; }
    }
}
