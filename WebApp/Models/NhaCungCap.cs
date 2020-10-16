using System;
using System.Collections.Generic;

namespace WebApp.Models
{
    public partial class NhaCungCap
    {
        public int Id { get; set; }
        public string Ten { get; set; }
        public DateTime? NgayTao { get; set; }
        public bool? IsDelete { get; set; }
    }
}
