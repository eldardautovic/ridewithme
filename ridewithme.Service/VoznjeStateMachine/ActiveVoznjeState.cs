using MapsterMapper;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.VoznjeStateMachine
{
    public class ActiveVoznjeState : BaseVoznjeState
    {
        public ActiveVoznjeState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Voznje Hide(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "hidden";

            Context.SaveChanges();

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override Model.Voznje Book(int id, VoznjeBookRequest request)
        {

            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);
            
            var klijent = Context.Korisnicis.Find(id);

            if(klijent == null)
            {
                throw new UserException("Korisnik sa tim ID-om ne postoji.");
            }

            if (entity.VozacId == request.KlijentId)
            {
                throw new UserException("Ne možete biti i vozač i klijent.");
            }

            if (klijent != null)
            {
                var klijentRides = Context.Voznje.FirstOrDefault(x => (x.KlijentId == request.KlijentId || x.VozacId == request.KlijentId) && (x.StateMachine == "booked" || x.StateMachine == "inprogress"));

                if(klijentRides != null)
                {
                    throw new UserException("Već ste klijent/vozač u drugoj bukiranoj/aktivnoj vožnji.");
                }

                entity.KlijentId = request.KlijentId;
                
                entity.StateMachine = "booked";

                Context.SaveChanges();
            }

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override List<string> AllowedActions(Database.Voznje entity)
        {
            return new List<string>() { nameof(Hide), nameof(Book) };
        }
    }
}
