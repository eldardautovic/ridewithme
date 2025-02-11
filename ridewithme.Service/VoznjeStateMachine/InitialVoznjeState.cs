using Microsoft.Extensions.Logging;
using MapsterMapper;
using ridewithme.Model;
using ridewithme.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace ridewithme.Service.VoznjeStateMachine
{
    public class InitialVoznjeState : BaseVoznjeState
    {
        ILogger<InitialVoznjeState> _logger;
        public InitialVoznjeState(Database.RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider, ILogger<InitialVoznjeState> logger) : base(dbContext, mapper, serviceProvider)
        {
            _logger = logger;
        }


        public override Voznje Insert(VoznjeInsertRequest request)
        {

            if (Context.Korisnicis.FirstOrDefault(x => x.Id == request.VozacId) == null)
            {
                throw new UserException("Korisnik sa tim ID-om ne postoji.");
            }

            if(request.Cijena <= 0)
            {
                throw new UserException("Cijena ne moze biti manja ili jednaka nuli.");
            }

            if (Context.Gradovi.FirstOrDefault(x => x.Id == request.GradOdId) == null)
            {
                throw new UserException("GradOd ne postoji.");
            }

            if (Context.Gradovi.FirstOrDefault(x => x.Id == request.GradDoId) == null)
            {
                throw new UserException("GradDo ne postoji.");
            }

            if (request.GradOdId == request.GradDoId)
            {
                throw new UserException("Grad polaska ne moze biti jednak Gradu dolaska.");
            }

            if (request.DatumVrijemePocetka != null && request.DatumVrijemePocetka < DateTime.Now)
            {
                throw new UserException("Datum vrijeme pocetka ne moze biti manje od danasnjeg datuma.");
            }

            var voznjeSet = Context.Set<Database.Voznje>();

            Mapper.Config.Default.IgnoreNullValues(true);

            var entity = Mapper.Map<Database.Voznje>(request);

            Mapper.Config.Default.IgnoreNullValues(false);

            entity.StateMachine = "draft";
            entity.DatumKreiranja = DateTime.Now;

            voznjeSet.Add(entity);

            Context.SaveChanges();

            _logger.LogInformation($"[+] Kreirana je nova Voznja ID: {entity.Id} | Vozac ID: {request.VozacId}");

            return Mapper.Map<Voznje>(entity);
        }

        public override List<string> AllowedActions(Database.Voznje entity)
        {
            return new List<string>() { nameof(Insert) };
        }
    }
}
