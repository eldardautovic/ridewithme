using ridewithme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IStatistikaService
    {
        public PagedResult<Statistika> GetList();
    }
}
