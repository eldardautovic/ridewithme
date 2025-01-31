using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model;
using ridewithme.Service.Database;
using ridewithme.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mapster;

namespace ridewithme.Service.ObavjestenjaStateMachine
{
    public class DraftObavjestenjaState : BaseObavjestenjaState
    {
        public DraftObavjestenjaState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider) : base(dbContext, mapper, serviceProvider)
        {
        }

        public override Model.Obavjestenja Update(int id, ObavjestenjaUpdateRequest request)
        {
            var set = Context.Set<Database.Obavjestenja>();

            var entity = set.Find(id);

            if (entity == null)
            {
                throw new UserException("Voznja sa tim ID-om ne postoji.");
            }

            Mapper.Config.Default.IgnoreNullValues(true);

            Mapper.Map(request, entity);

            Context.SaveChanges();

            Mapper.Config.Default.IgnoreNullValues(false);

            return Mapper.Map<Model.Obavjestenja>(entity);
        }

        public override Model.Obavjestenja Activate(int id)
        {
            var set = Context.Set<Database.Obavjestenja>();

            var entity = set.FirstOrDefault(x => x.Id == id);

            entity.StateMachine = "active";

            var mappedEntity = Mapper.Map<Model.Obavjestenja>(entity);

            Context.SaveChanges();

            return mappedEntity;
        }

        public override Model.Obavjestenja Hide(int id)
        {
            var set = Context.Set<Database.Obavjestenja>();

            var entity = set.Find(id);

            entity.StateMachine = "hidden";

            Context.SaveChanges();

            return Mapper.Map<Model.Obavjestenja>(entity);
        }

        public override Model.Obavjestenja Delete(int id)
        {
            var set = Context.Set<Database.Obavjestenja>();

            var entity = set.Find(id);

            set.Remove(entity);

            Context.SaveChanges();

            return Mapper.Map<Model.Obavjestenja>(entity);
        }

        public override List<string> AllowedActions(Database.Obavjestenja entity)
        {
            return new List<string>() { nameof(Activate), nameof(Hide), nameof(Update), nameof(Delete) };
        }
    }
}
