using MapsterMapper;
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

        public override Model.Voznje Book(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "booked";

            Context.SaveChanges();

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override List<string> AllowedActions(Voznje entity)
        {
            return new List<string>() { nameof(Hide), nameof(Book) };
        }
    }
}
