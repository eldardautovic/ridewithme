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
    public class UlogeService : BaseCRUDService<Model.Uloge, UlogeSearchObject, Database.Uloge, UlogeUpsertRequest, UlogeUpsertRequest>, IUlogeService
    {
        public UlogeService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

    }
}
