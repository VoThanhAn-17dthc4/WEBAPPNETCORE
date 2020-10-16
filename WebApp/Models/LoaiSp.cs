using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class LoaiSp
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public bool? IsDelete { get; set; }
    }
}
