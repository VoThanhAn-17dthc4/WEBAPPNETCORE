using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class SizeViewModel
    {
        public int Id { get; set; }
        public int? IdSp { get; set; }
        public int? SizeNumber { get; set; }
        public int? SoLuongKho { get; set; }
        public bool? IsDelete { get; set; }
    }
}
