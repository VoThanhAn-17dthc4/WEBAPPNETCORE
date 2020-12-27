﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApp.Models
{
    public class TopSanPhamBanCham
    {
        public int Id { get; set; }

        public int? IdLoai { get; set; }

        public string Ten { get; set; }

        public string AnhMoTa { get; set; }


        public double? DonGia { get; set; }

        public bool? IsDelete { get; set; }
        public int? Tongsl { get; set; }
    }
}
