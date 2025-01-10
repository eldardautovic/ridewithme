using Azure.Core;
using EasyNetQ;
using Mapster;
using MapsterMapper;
using ridewithme.Model;
using ridewithme.Model.Messages;
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

            if (entity == null)
            {
                throw new UserException("Voznja sa tim ID-om ne postoji.");
            }

            if(request.GradOdId != null && Context.Gradovi.Find(request.GradOdId) == null)
            {
                throw new UserException("GradOd ne postoji.");
            }

            if (request.GradDoId != null && Context.Gradovi.Find(request.GradDoId) == null)
            {
                throw new UserException("GradDo ne postoji.");
            }

            if (request.GradDoId != null && request.GradOdId != null && request.GradOdId == request.GradDoId)
            {
                throw new UserException("Grad polaska ne moze biti jednak Gradu dolaska.");
            }

            if(request.Cijena != null && request.Cijena <= 0)
            {
                throw new UserException("Cijena ne moze biti manja ili jednaka 0.");
            }

            Mapper.Config.Default.IgnoreNullValues(true);

            Mapper.Map(request, entity);

            Context.SaveChanges();

            Mapper.Config.Default.IgnoreNullValues(false);

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override Model.Voznje Activate(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "active";

            var bus = RabbitHutch.CreateBus("host=localhost");

            var mappedEntity = Mapper.Map<Model.Voznje>(entity);

            VoznjeActivated message = new VoznjeActivated{ Voznja = mappedEntity };

            bus.PubSub.Publish(message);

            Context.SaveChanges();

            return mappedEntity;
        }

        public override Model.Voznje Hide(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            entity.StateMachine = "hidden";

            Context.SaveChanges();

            return Mapper.Map<Model.Voznje>(entity);
        }

        public override string Delete(int id)
        {
            var set = Context.Set<Database.Voznje>();

            var entity = set.Find(id);

            set.Remove(entity);

            Context.SaveChanges();

            return "Voznja je uspjesno obrisana.";
        }

        public override List<string> AllowedActions(Database.Voznje entity)
        {
            return new List<string>() { nameof(Activate), nameof(Hide), nameof(Update) };
        }
    }
}
