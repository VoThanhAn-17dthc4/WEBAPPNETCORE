using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Models;
namespace WebApp.Repository
{
    public class GioHangRepository : GenericRepository<Giohang>, IGioHang
    {
        public Giohang FindByIdTK(int? idtk)
        {
            var item = _db.Giohang.SingleOrDefault(x => x.IdTk == idtk);
            return item;
        }
    }
}
