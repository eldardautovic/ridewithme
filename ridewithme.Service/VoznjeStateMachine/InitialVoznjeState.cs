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
            var voznjeSet = Context.Set<Database.Voznje>();
            var korisniciVoznjeSet = Context.Set<Database.KorisniciVoznje>();

            var entity = Mapper.Map<Database.Voznje>(request);

            entity.StateMachine = "draft";

            voznjeSet.Add(entity);

            Context.SaveChanges();

            //var tempKorisniciUlogeObject = new Database.KorisniciVoznje()
            //{
            //    VoznjaId = entity.Id,
            //    KorisnikId = request.VozacId,
            //    Vozac = true
            //};

            //korisniciVoznjeSet.Add(tempKorisniciUlogeObject);

            //Context.SaveChanges();

            return Mapper.Map<Voznje>(entity);
        }

        public override List<string> AllowedActions(Database.Voznje entity)
        {
            return new List<string>() { nameof(Insert) };
        }
    }
}
