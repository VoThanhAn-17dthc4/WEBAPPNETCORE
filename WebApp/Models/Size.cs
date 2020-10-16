using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class Size
    {
        public int Id { get; set; }
        public int? IdSp { get; set; }
        public int? SizeNumber { get; set; }
        public int? SoLuongKho { get; set; }
        public bool? IsDelete { get; set; }
    }
}
