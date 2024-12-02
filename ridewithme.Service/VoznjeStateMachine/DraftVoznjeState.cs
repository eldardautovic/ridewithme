using Azure.Core;
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
    public class DraftVoznjeState : BaseVoznjeState
    {
        public DraftVoznjeState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Voznje Update(int id, VoznjeUpdateRequest request)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            Mapper.Map(request, entity);

            Context.SaveChanges();

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override Model.Voznje Activate(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "active";

            Context.SaveChanges();

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override Model.Voznje Hide(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "hidden";

            Context.SaveChanges();

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override List<string> AllowedActions(Voznje entity)
        {
            return new List<string>() { nameof(Activate), nameof(Hide), nameof(Update) };
        }
    }
}
