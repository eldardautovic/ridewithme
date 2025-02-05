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
    public class ReklameService : BaseCRUDService<Model.Reklame, ReklameSearchObject, Database.Reklame, ReklameInsertRequest, ReklameUpdateRequest>, IReklameService
    {
        public ReklameService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override IQueryable<Reklame> AddFilter(ReklameSearchObject searchObject, IQueryable<Reklame> query)
        {
            if(!string.IsNullOrWhiteSpace(searchObject.NazivKlijentaGTE))
            {
                query = query.Where(x => x.NazivKlijenta.Contains(searchObject.NazivKlijentaGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject.NazivKampanjeGTE))
            {
                query = query.Where(x => x.NazivKampanje.Contains(searchObject.NazivKampanjeGTE));
            }

            return query;
        }

        public Model.Reklame Delete(int id)
        {
            var set = Context.Set<Reklame>();

            var entity = set.Find(id);

            set.Remove(entity);

            Context.SaveChanges();

            return Mapper.Map<Model.Reklame>(entity);
        }


    }
}
