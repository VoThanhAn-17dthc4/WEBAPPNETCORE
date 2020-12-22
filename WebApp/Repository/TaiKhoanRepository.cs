using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Models;

namespace WebApp.Repository
{
    public class TaiKhoanRepository : GenericRepository<TaiKhoan>, ITaiKhoan
    {
        public bool? checkisdelete(string name)
        {
            var result = _db.TaiKhoan.SingleOrDefault(x => x.TenTaiKhoan == name);
            return result.IsDelete;
        }

        public TaiKhoan Login(string name, string pass)
        {
            var result = _db.TaiKhoan.SingleOrDefault(x => x.TenTaiKhoan == name && x.MatKhau == pass && x.IsDelete != true);
            return result;
        }

        public int? Namebyid(string name)
        {
            var result = _db.TaiKhoan.SingleOrDefault(x => x.TenTaiKhoan == name && x.IsDelete != true);
            return result.Id;
        }
    }
}
