using MapsterMapper;
using ridewithme.Model;
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
    public class VoznjeService : BaseCRUDService<Model.Voznje, VoznjeSearchObject, Database.Voznje, VoznjeInsertRequest, VoznjeUpdateRequest>, IVoznjeService
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

        public override void BeforeInsert(VoznjeInsertRequest request, Database.Voznje entity)
        {
            //TODO: throw exception if vozacId not existing
            base.BeforeInsert(request, entity);
        }

    }
}
