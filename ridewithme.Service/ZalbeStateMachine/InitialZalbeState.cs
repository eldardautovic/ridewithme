using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Mapster;

namespace ridewithme.Service.ZalbeStateMachine
{
    public class InitialZalbeState : BaseZalbeState
    {
        ILogger<InitialZalbeState> _logger;
        public InitialZalbeState(Database.RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider, ILogger<InitialZalbeState> logger) : base(dbContext, mapper, serviceProvider)
        {
            _logger = logger;
        }


        public override Zalbe Insert(ZalbeInsertRequest request)
        {

            if (Context.Korisnicis.FirstOrDefault(x => x.Id == request.KorisnikId) == null)
            {
                throw new UserException("Korisnik sa tim ID-om ne postoji.");
            }

            var zalbeSet = Context.Set<Database.Zalbe>();

            Mapper.Config.Default.IgnoreNullValues(true);

            var entity = Mapper.Map<Database.Zalbe>(request);

            Mapper.Config.Default.IgnoreNullValues(false);

            entity.StateMachine = "active";

            entity.DatumIzmjene = DateTime.Now;

            entity.DatumKreiranja = DateTime.Now;

            zalbeSet.Add(entity);

            Context.SaveChanges();

            _logger.LogInformation($"[+] Kreirana je nova Zalba ID: {entity.Id} | Korisnik ID: {request.KorisnikId}");

            //TODO: Slanje notifikacije/mejla administratorima da je kreirana nova zalba

            return Mapper.Map<Zalbe>(entity);
        }

        public override List<string> AllowedActions(Database.Zalbe entity)
        {
            return new List<string>() { nameof(Insert) };
        }
    }
}
