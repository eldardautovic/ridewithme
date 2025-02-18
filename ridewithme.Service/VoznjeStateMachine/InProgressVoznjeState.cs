using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.VoznjeStateMachine
{
    public class InProgressVoznjeState : BaseVoznjeState
    {
        public InProgressVoznjeState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }
        public override Model.Voznje Complete(int id, VoznjeCompleteRequest request)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "completed";
            entity.DatumVrijemeZavrsetka = DateTime.Now;

            var mappedEntity = Mapper.Map<Model.Voznje>(entity);

            Context.SaveChanges();

            return mappedEntity;
        }

        public override List<string> AllowedActions(Database.Voznje entity)
        {
            return new List<string>() { nameof(Complete) };
        }
    }
}
