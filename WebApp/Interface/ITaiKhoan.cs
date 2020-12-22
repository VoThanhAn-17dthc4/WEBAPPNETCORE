using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Interface
{
    public interface ITaiKhoan:IGenericRepository<TaiKhoan>
    {
        TaiKhoan Login(string name, string pass);
        bool? checkisdelete(string name);
        int? Namebyid(string name);
    }
}
