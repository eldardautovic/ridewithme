using MapsterMapper;
using ridewithme.Model;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class VoznjeService : BaseService<Model.Voznje, VoznjeSearchObject, Database.Voznje>, IVoznjeService
    {

        public VoznjeService(RidewithmeContext dbContext, IMapper mapper) 
            : base(dbContext, mapper) { 
        }

        public override IQueryable<Database.Voznje> AddFilter(VoznjeSearchObject searchObject, IQueryable<Database.Voznje> query)
        {

            var filteredQuery = base.AddFilter(searchObject, query);

            if (searchObject?.VoznjaId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.Id == searchObject.VoznjaId.Value);
            }

            return filteredQuery;
        }

    }
}
