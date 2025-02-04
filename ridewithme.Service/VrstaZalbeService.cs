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
    public class VrstaZalbeService : BaseCRUDService<Model.VrstaZalbe, VrstaZalbeSearchObject, Database.VrstaZalbe, VrstaZalbeInsertRequest, VrstaZalbeUpdateRequest>, IVrstaZalbeService
    {
        public VrstaZalbeService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }


        public override IQueryable<VrstaZalbe> AddFilter(VrstaZalbeSearchObject searchObject, IQueryable<VrstaZalbe> query)
        {
            if (!string.IsNullOrEmpty(searchObject.NazivGTE))
            {
                query = query.Where(x => x.Naziv.Contains(searchObject.NazivGTE));
            }

            return query;
        }

    }
}
