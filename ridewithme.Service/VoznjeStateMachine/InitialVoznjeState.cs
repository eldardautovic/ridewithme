using MapsterMapper;
using ridewithme.Model;
using ridewithme.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.VoznjeStateMachine
{
    public class InitialVoznjeState : BaseVoznjeState
    {
        public InitialVoznjeState(Database.RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Voznje Insert(VoznjeInsertRequest request)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = Mapper.Map<Database.Voznje>(request);

            entity.StateMachine = "draft";

            set.Add(entity);

            Context.SaveChanges();

            return Mapper.Map<Voznje>(entity);
        }
    }
}
