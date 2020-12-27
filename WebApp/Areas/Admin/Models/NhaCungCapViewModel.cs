using System;

namespace WebApp.Areas.Admin.Models
{
    internal class NhaCungCapViewModel
    {
        public DateTime? NgayTao { get; internal set; }
        public string Ten { get; internal set; }
        public int Id { get; internal set; }
        public bool? IsDelete { get; internal set; }
    }
}