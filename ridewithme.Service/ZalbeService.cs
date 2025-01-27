using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using ridewithme.Service.KuponiStateMachine;
using ridewithme.Service.ZalbeStateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class ZalbeService : BaseCRUDService<Model.Zalbe, ZalbeSearchObject, Database.Zalbe, ZalbeInsertRequest, ZalbeUpdateRequest>, IZalbeService
    {
        public BaseZalbeState BaseZalbeState { get; set; }

        public ZalbeService(RidewithmeContext dbContext, IMapper mapper, BaseZalbeState baseZalbeState) : base(dbContext, mapper)
        {
            BaseZalbeState = baseZalbeState;
        }

        public override IQueryable<Zalbe> AddFilter(ZalbeSearchObject searchObject, IQueryable<Zalbe> query)
        {
            if(!string.IsNullOrWhiteSpace(searchObject.NaslovGTE))
            {
                query = query.Where(x => x.Naslov.Contains(searchObject.NaslovGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject.SadrzajGTE))
            {
                query = query.Where(x => x.Sadrzaj.Contains(searchObject.SadrzajGTE));
            }

            if (searchObject.DatumKreiranja.HasValue)
            {
                query = query.Where(x => x.DatumKreiranja == searchObject.DatumKreiranja.Value);
            }

            if (searchObject.DatumIzmjene.HasValue)
            {
                query = query.Where(x => x.DatumIzmjene == searchObject.DatumIzmjene.Value);
            }

            if (searchObject.DatumPreuzimanja.HasValue)
            {
                query = query.Where(x => x.DatumPreuzimanja == searchObject.DatumPreuzimanja.Value);
            }

            if(!string.IsNullOrWhiteSpace(searchObject.VrstaZalbe))
            {
                query = query.Include(x => x.VrstaZalbe).Where(x => x.VrstaZalbe.Naziv == searchObject.VrstaZalbe);
            }

            if(searchObject.AdministratorId.HasValue)
            {
                query = query.Where(x => x.AdministratorId ==  searchObject.AdministratorId.Value);
            }

            if (searchObject.KorisnikId.HasValue)
            {
                query = query.Where(x => x.KorisnikId == searchObject.KorisnikId.Value);
            }

            if (searchObject.IsVrstaZalbeIncluded.HasValue && searchObject.IsVrstaZalbeIncluded == true)
            {
                query = query.Include(x => x.VrstaZalbe);
            }

            if (searchObject.IsAdministratorIncluded.HasValue && searchObject.IsAdministratorIncluded == true)
            {
                query = query.Include(x => x.Administrator);
            }

            if (searchObject.IsKorisnikIncluded.HasValue && searchObject.IsKorisnikIncluded == true)
            {
                query = query.Include(x => x.Korisnik);
            }


            if (!string.IsNullOrWhiteSpace(searchObject?.KorisnickoImeAdministratorGTE))
            {
                query = query.Where(x => x.Administrator.KorisnickoIme.Contains(searchObject.KorisnickoImeAdministratorGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.KorisnickoImeKorisnikGTE))
            {
                query = query.Where(x => x.Korisnik.KorisnickoIme.Contains(searchObject.KorisnickoImeKorisnikGTE));
            }

            return query;
        }

        public override Model.Zalbe Insert(ZalbeInsertRequest request)
        {
            var state = BaseZalbeState.CreateState("initial");
            return state.Insert(request);
        }

        public Model.Zalbe Processing(int id, int administratorId)
        {
            var entity = GetById(id);
            var state = BaseZalbeState.CreateState(entity.StateMachine);

            return state.Processing(id, administratorId);
        }

        public Model.Zalbe Activate(int id)
        {
            var entity = GetById(id);
            var state = BaseZalbeState.CreateState(entity.StateMachine);

            return state.Activate(id);
        }

        public string Delete(int id)
        {
            var entity = GetById(id);
            var state = BaseZalbeState.CreateState(entity.StateMachine);

            return state.Delete(id);
        }

        public Model.Zalbe Complete(int id, ZalbeCompleteRequest request)
        {
            var entity = GetById(id);
            var state = BaseZalbeState.CreateState(entity.StateMachine);

            return state.Complete(id, request);
        }

        public List<string> AllowedActions(int id)
        {
            if (id <= 0)
            {
                var state = BaseZalbeState.CreateState("initial");
                return state.AllowedActions(null);
            }
            else
            {
                var entity = Context.Zalbe.Find(id);
                var state = BaseZalbeState.CreateState(entity.StateMachine);
                return state.AllowedActions(entity);
            }
        }
    }
}
