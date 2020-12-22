using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class DoanhThuTheoTungThang
    {
        [Key]
        public int? Thang { set; get; }
        public double? Tongthu { set; get; }
        public double? Tongchi { set; get; }
        public double? Loinhuan { set; get; }
    }
}
