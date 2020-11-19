using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Areas.Admin.Models
{
    public class LoaiSPViewModel
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public bool? IsDelete { get; set; }
    }
}
