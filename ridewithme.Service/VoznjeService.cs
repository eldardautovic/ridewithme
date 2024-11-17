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
    public class VoznjeService : IVoznjeService
    {
        public RidewithmeContext Context { get; set; }

        public IMapper Mapper { get; set; }

        public VoznjeService(RidewithmeContext dbContext, IMapper mapper)
        {
            Context = dbContext;
            Mapper = mapper;
        }
        public List<Model.Voznje> GetList(VoznjeSearchObject searchObject)
        {
            
            List<Model.Voznje> result = new List<Model.Voznje>();

            var query = Context.Voznjes.AsQueryable();

            if(searchObject.VoznjaId != null)
            {
                query = query.Where(x => x.VozacId == searchObject.VoznjaId);
            }

            if (searchObject.DatumVrijemePocetka != null)
            {
                query = query.Where(x => x.DatumVrijemePocetka == searchObject.DatumVrijemePocetka);
            }

            if (searchObject.DatumVrijemeZavrsetka != null)
            {
                query = query.Where(x => x.DatumVrijemeZavrsetka == searchObject.DatumVrijemeZavrsetka);
            }

            var list = query.ToList();

            result = Mapper.Map(list, result);

            return result;

        }
    }
}
