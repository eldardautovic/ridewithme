using MapsterMapper;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.KuponiStateMachine
{
    public class HiddenKuponiState: BaseKuponiState
    {
        public HiddenKuponiState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Kuponi Edit(int id)
        {
            var set = Context.Set<Database.Kuponi>();

            var entity = set.Find(id);

            entity.StateMachine = "draft";

            entity.DatumIzmjene = DateTime.Now;

            Context.SaveChanges();

            return Mapper.Map<Model.Kuponi>(entity);
        }

        public override List<string> AllowedActions(Kuponi entity)
        {
            return new List<string>() { nameof(Edit) };
        }
    }
}
