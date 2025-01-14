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
    public class ReklameService : BaseCRUDService<Model.Reklame, ReklameSearchObject, Database.Reklame, ReklameUpsertRequest, ReklameUpsertRequest>, IReklameService
    {
        public ReklameService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }



    }
}
