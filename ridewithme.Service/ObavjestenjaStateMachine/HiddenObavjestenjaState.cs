using MapsterMapper;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.ObavjestenjaStateMachine
{
    public class HiddenObavjestenjaState : BaseObavjestenjaState
    {
        public HiddenObavjestenjaState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Obavjestenja Edit(int id)
        {
            var set = Context.Set<Database.Obavjestenja>();

            var entity = set.Find(id);

            entity.StateMachine = "draft";

            Context.SaveChanges();

            return Mapper.Map<Model.Obavjestenja>(entity);
        }

        public override List<string> AllowedActions(Obavjestenja entity)
        {
            return new List<string>() { nameof(Edit) };
        }
    }
}

