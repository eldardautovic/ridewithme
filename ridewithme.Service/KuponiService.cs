using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using ridewithme.Service.KuponiStateMachine;
using ridewithme.Service.VoznjeStateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class KuponiService : BaseCRUDService<Model.Kuponi, KuponiSearchObject, Database.Kuponi, KuponiInsertRequest, KuponiUpdateRequest>, IKuponiService
    {
        public BaseKuponiState BaseKuponiState { get; set; }
        public KuponiService(RidewithmeContext dbContext, IMapper mapper, BaseKuponiState baseKuponiState) : base(dbContext, mapper)
        {
            BaseKuponiState = baseKuponiState;
        }

        public override Model.Kuponi Insert(KuponiInsertRequest request)
        {
            var state = BaseKuponiState.CreateState("initial");
            return state.Insert(request);
        }

        public override Model.Kuponi Update(int id, KuponiUpdateRequest request)
        {
            var entity = GetById(id);
            var state = BaseKuponiState.CreateState(entity.StateMachine);

            return state.Update(id, request);
        }

        public override IQueryable<Kuponi> AddFilter(KuponiSearchObject searchObject, IQueryable<Kuponi> query)
        {
            if(searchObject.KuponId.HasValue)
            {
                query = query.Where(x => x.Id == searchObject.KuponId.Value);
            }

            if(searchObject.PopustGTE.HasValue)
            {
                query = query.Where(x => x.Popust >=  searchObject.PopustGTE.Value);
            }

            if(searchObject.BrojIskoristivostiGTE.HasValue)
            {
                query = query.Where(x => x.BrojIskoristivosti >= searchObject.BrojIskoristivostiGTE.Value);
            }

            if(searchObject.DatumPocetka.HasValue)
            {
                query = query.Where(x => x.DatumPocetka == searchObject.DatumPocetka.Value);
            }

            if(!string.IsNullOrWhiteSpace(searchObject.Kod)) 
            {
                query = query.Where(x => x.Kod ==  searchObject.Kod);
            }

            if (!string.IsNullOrWhiteSpace(searchObject.Naziv))
            {
                query = query.Where(x => x.Naziv == searchObject.Naziv);
            }

            return query;
        }

        public Model.Kuponi Activate(int id)
        {
            var entity = GetById(id);
            var state = BaseKuponiState.CreateState(entity.StateMachine);

            return state.Activate(id);
        }
        public Model.Kuponi Hide(int id)
        {
            var entity = GetById(id);
            var state = BaseKuponiState.CreateState(entity.StateMachine);

            return state.Hide(id);
        }

        public Model.Kuponi Edit(int id)
        {
            var entity = GetById(id);
            var state = BaseKuponiState.CreateState(entity.StateMachine);

            return state.Edit(id);
        }

        public List<string> AllowedActions(int id)
        {
            if (id <= 0)
            {
                var state = BaseKuponiState.CreateState("initial");
                return state.AllowedActions(null);
            }
            else
            {
                var entity = Context.Kuponi.Find(id);
                var state = BaseKuponiState.CreateState(entity.StateMachine);
                return state.AllowedActions(entity);
            }
        }

    }
}
