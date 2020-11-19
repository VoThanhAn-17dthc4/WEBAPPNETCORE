using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Models; 
namespace WebApp.Repository
{
    public class CTGioHangRepository : GenericRepository<CtgioHang>, ICTGioHang
    {
        public CtgioHang FindByIdGH(int? gh)
        {
            throw new NotImplementedException();
        }

        public CtgioHang FindByIdSP(int? size, int? idsp, int? gh)
        {
            var item = _db.CtgioHang.SingleOrDefault(x => x.IdSize == size && x.IdSp == idsp && x.IdGh == gh);
            return item;
        }
    }
}
