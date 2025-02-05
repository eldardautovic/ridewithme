using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;

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

            if (!string.IsNullOrWhiteSpace(searchObject?.OrderBy))
            {
                var items = searchObject.OrderBy.Split(' ');
                if (items.Length > 2 || items.Length == 0)
                {
                    throw new ApplicationException("Mozete sortirati samo po dva polja.");
                }
                if (items.Length == 1)
                {
                    query = query.OrderBy("@0", searchObject.OrderBy);
                }
                else
                {
                    query = query.OrderBy(string.Format("{0} {1}", items[0], items[1]));
                }

            }

            return query;
        }

        public Model.Dogadjaji Delete(int id)
        {
            var set = Context.Set<Dogadjaji>();

            var entity = set.Find(id);

            set.Remove(entity);

            Context.SaveChanges();

            return Mapper.Map<Model.Dogadjaji>(entity);
        }

    }
}
