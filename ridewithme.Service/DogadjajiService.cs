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
    public class DogadjajiService : BaseCRUDService<Model.Dogadjaji, DogadjajiSearchObejct, Database.Dogadjaji, DogadjajiUpsertRequest, DogadjajiUpsertRequest>, IDogadjaji
    {
        public DogadjajiService(RidewithmeContext dbContext, IMapper mapper) : base(dbContext, mapper)
        {
        }

        public override IQueryable<Dogadjaji> AddFilter(DogadjajiSearchObejct searchObject, IQueryable<Dogadjaji> query)
        {

            if (!string.IsNullOrWhiteSpace(searchObject.NazivGTE))
            {
                query = query.Where(x => x.Naziv.Contains(searchObject.NazivGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject.OpisGTE))
            {
                query = query.Where(x => x.Opis.Contains(searchObject.OpisGTE));
            }

            if (searchObject.DatumPocetka.HasValue)
            {
                query = query.Where(x => x.DatumPocetka == searchObject.DatumPocetka.Value);
            }

            if (searchObject.DatumZavrsetka.HasValue)
            {
                query = query.Where(x => x.DatumZavrsetka == searchObject.DatumZavrsetka.Value);
            }

            return query;
        }

    }
}
