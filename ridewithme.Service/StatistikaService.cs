using MapsterMapper;
using ridewithme.Model;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class StatistikaService : IStatistikaService
    {
        RidewithmeContext context;

        public StatistikaService(RidewithmeContext dbContext, IMapper mapper)
        {
            context = dbContext;
        }
        public Statistika GetList()
        {
            return new Statistika
            {
                BrojIskoristenihKupona = context.Kuponi.Count(x => x.BrojIskoristivosti == 0),
                BrojKreiranihVoznji = context.Voznje.Count(),
                BrojRegistrovanihKorisnika = context.Korisnicis.Count()
            };
        }
    }
}
