using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IVoznjeService : ICRUDService<Voznje, VoznjeSearchObject, VoznjeInsertRequest, VoznjeUpdateRequest>
    {
       
    }
}
