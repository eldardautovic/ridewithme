using EasyNetQ;
using MapsterMapper;
using ridewithme.Model.Messages;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.VoznjeStateMachine
{
    public class BookedVoznjeState : BaseVoznjeState
    {
        public BookedVoznjeState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Voznje Activate(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "active";

            entity.Klijent = null;

            var mappedEntity = Mapper.Map<Model.Voznje>(entity);

            Context.SaveChanges();

            return mappedEntity;
        }

        public override List<string> AllowedActions(Database.Voznje entity)
        {
            return new List<string>() { nameof(Activate) };
        }


    }
}
