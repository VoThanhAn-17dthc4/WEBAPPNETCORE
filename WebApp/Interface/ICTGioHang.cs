using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Interface
{
    public interface ICTGioHang:IGenericRepository<CtgioHang>
    {
        CtgioHang FindByIdSP(int? size, int? idsp, int? gh);
        CtgioHang FindByIdGH(int? gh);
    }
}
