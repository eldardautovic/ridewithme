using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using ridewithme.Service.ObavjestenjaStateMachine;
using ridewithme.Service.ZalbeStateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class ObavjestenjaService : BaseCRUDService<Model.Obavjestenja, ObavjestenjaSearchObject, Database.Obavjestenja, ObavjestenjaInsertRequest, ObavjestenjaUpdateRequest>, IObavjestenjaService
    {
        public BaseObavjestenjaState BaseObavjestenjaState { get; set; }

        public ObavjestenjaService(RidewithmeContext dbContext, IMapper mapper, BaseObavjestenjaState baseObavjestenjaState) : base(dbContext, mapper)
        {
            BaseObavjestenjaState = baseObavjestenjaState;
        }

        public override IQueryable<Obavjestenja> AddFilter(ObavjestenjaSearchObject searchObject, IQueryable<Obavjestenja> query)
        {
            if (searchObject.IsCompletedIncluded.HasValue && searchObject.IsCompletedIncluded == false)
            {
                query = query.Where(x => x.DatumZavrsetka > DateTime.Now || x.StateMachine == "active");
            }

            return query;
        }

        public override Model.Obavjestenja Insert(ObavjestenjaInsertRequest request)
        {
            var state = BaseObavjestenjaState.CreateState("initial");
            return state.Insert(request);
        }

        public override Model.Obavjestenja Update(int id, ObavjestenjaUpdateRequest request)
        {
            var entity = GetById(id);
            var state = BaseObavjestenjaState.CreateState(entity.StateMachine);

            return state.Update(id, request);
        }
        public List<string> AllowedActions(int id)
        {
            if (id <= 0)
            {
                var state = BaseObavjestenjaState.CreateState("initial");
                return state.AllowedActions(null);
            }
            else
            {
                var entity = Context.Obavjestenja.Find(id);
                var state = BaseObavjestenjaState.CreateState(entity.StateMachine);
                return state.AllowedActions(entity);
            }
        }

        public Model.Obavjestenja Activate(int id)
        {
            var entity = GetById(id);
            var state = BaseObavjestenjaState.CreateState(entity.StateMachine);

            return state.Activate(id);
        }

        public Model.Obavjestenja Complete(int id)
        {
            var entity = GetById(id);
            var state = BaseObavjestenjaState.CreateState(entity.StateMachine);

            return state.Complete(id);
        }

        public Model.Obavjestenja Hide(int id)
        {
            var entity = GetById(id);
            var state = BaseObavjestenjaState.CreateState(entity.StateMachine);

            return state.Hide(id);
        }

        public Model.Obavjestenja Edit(int id)
        {
            var entity = GetById(id);
            var state = BaseObavjestenjaState.CreateState(entity.StateMachine);

            return state.Edit(id);
        }

    }
}
