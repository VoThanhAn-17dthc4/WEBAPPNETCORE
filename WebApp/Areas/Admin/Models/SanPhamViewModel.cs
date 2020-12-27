using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class SanPhamViewModel
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public double? DonGia { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NoiDung { get; set; }
        public string AnhMoTa { get; set; }
        public bool? IsDelete { get; set; }
        public IFormFile ProfileImage { get; set; }
        public int? IdLoai { get; set; }
        public List<SizeViewModel> SizeViewModel { get; set; }
    }
}
