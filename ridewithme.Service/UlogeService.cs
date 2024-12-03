using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class Ulogeervice : BaseCRUDService<Model.Uloge, UlogeearchObject, Database.Uloge, UlogeUpsertRequest, UlogeUpsertRequest>, IUlogeervice
    {
        public Ulogeervice(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

    }
}
