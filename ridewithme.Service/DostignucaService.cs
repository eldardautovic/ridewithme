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
    public class DostignucaService : BaseCRUDService<Model.Dostignuca, DostignucaSearchObject, Database.Dostignuca, DostignucaUpsertRequest, DostignucaUpsertRequest>, IDostignucaService
    {
        public DostignucaService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }


    }
}
