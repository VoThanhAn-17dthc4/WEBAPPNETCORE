using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Interface
{
    public interface ICTSanPham:IGenericRepository<CtsanPham>
    {
        CtsanPham findbyidsp(int? id,int? size);
    }
}
