using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApp.Interface;
using WebApp.Models;

namespace WebApp.Repository
{
    public class SizeRepository : GenericRepository<Size>, ISize
    {
        public Size findbysizeandid(int? id, int? size)
        {
            var sizeid = _db.Size.SingleOrDefault(x => x.IdSp == id && x.SizeNumber == size);
            return sizeid;
        }
    }
}
