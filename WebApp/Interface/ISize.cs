using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Models;

namespace WebApp.Interface
{
    public interface ISize:IGenericRepository<Size>
    {
        Size findbysizeandid(int? id, int? size);
        int? sltoida(int? id,int? size);
    }
}
