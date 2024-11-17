using ridewithme.Model;
using ridewithme.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IVoznjeService
    {
        List<Voznje> GetList(VoznjeSearchObject searchObject);
    }
}
