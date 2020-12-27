using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Models;
namespace WebApp.Repository
{
    public class CTSanPhamRepository : GenericRepository<CtsanPham>, ICTSanPham
    {
        public CtsanPham findbyidsp(int? id,int? size)
        {
            var sp = _db.CtsanPham.Where(x => x.IdSp == id && x.IdSize == size);
            return (CtsanPham)sp;
        }
    }
}
