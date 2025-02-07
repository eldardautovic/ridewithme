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
        public PagedResult<Statistika> GetList()
        {
            PagedResult<Statistika> paged = new PagedResult<Statistika>();

            paged.Count = 1;
            paged.Results = new List<Statistika>()
            {
                new Statistika
                {
                    BrojIskoristenihKupona = context.Kuponi.Count(x => x.BrojIskoristivosti == 0),
                    BrojKreiranihVoznji = context.Voznje.Count(),
                    BrojRegistrovanihKorisnika = context.Korisnicis.Count()
                }
            };

            return paged;
        }

        public UkupnaStatistika GetMonthlyStatistics()
        {
            var voznjePoMjesecu = context.Voznje
                .Where(x => x.DatumVrijemePocetka != null)
                .GroupBy(x => x.DatumVrijemePocetka.Value.Month)
                .Select(g => new MjesecnaStatistika { Mjesec = g.Key, BrojVoznji = g.Count() })
                .ToList();

            var UkupnaStatistika = new UkupnaStatistika()
            {
                MjesecnaStatistika = voznjePoMjesecu,
                Statistika = new Statistika
                {
                    BrojIskoristenihKupona = context.Kuponi.Count(x => x.BrojIskoristivosti == 0),
                    BrojKreiranihVoznji = context.Voznje.Count(),
                    BrojRegistrovanihKorisnika = context.Korisnicis.Count(),
                    BrojVozaca = context.Voznje.Select(x => x.VozacId).Distinct().Count(),
                    BrojZakazanihVoznji = context.Voznje.Where(x => x.StateMachine == "booked").Count()
                }
            };

            return UkupnaStatistika;

        }
    }
}
