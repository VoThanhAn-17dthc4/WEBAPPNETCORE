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
        public TaiKhoan Login(string name, string pass)
        {
            var result = _db.TaiKhoan.SingleOrDefault(x => x.TenTaiKhoan == name && x.MatKhau == pass);
            return result;
        }
    }
}
