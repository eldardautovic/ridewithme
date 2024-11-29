using Azure.Core;
using MapsterMapper;
using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using ridewithme.Service.VoznjeStateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class VoznjeService : BaseCRUDService<Model.Voznje, VoznjeSearchObject, Database.Voznje, VoznjeInsertRequest, VoznjeUpdateRequest>, IVoznjeService
    {
        public BaseVoznjeState BaseVoznjeState { get; set; }

        public VoznjeService(RidewithmeContext dbContext, IMapper mapper, BaseVoznjeState baseVoznjeState) 
            : base(dbContext, mapper) { 
            BaseVoznjeState = baseVoznjeState;
        }

        public override IQueryable<Database.Voznje> AddFilter(VoznjeSearchObject searchObject, IQueryable<Database.Voznje> query)
        {

            var filteredQuery = base.AddFilter(searchObject, query);

            if (searchObject?.VoznjaId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.Id == searchObject.VoznjaId.Value);
            }

            return filteredQuery;
        }

        public override void BeforeInsert(VoznjeInsertRequest request, Database.Voznje entity)
        {
            //TODO: throw exception if vozacId not existing
            base.BeforeInsert(request, entity);
        }

        public override Model.Voznje Insert(VoznjeInsertRequest request)
        {
            var state = BaseVoznjeState.CreateState("initial");
            return state.Insert(request);
        }

        public override Model.Voznje Update(int id, VoznjeUpdateRequest request)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Update(id, request);
        }

        public Model.Voznje Activate(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Activate(id);
        }
        public Model.Voznje Hide(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Hide(id);
        }

        public Model.Voznje Edit(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Edit(id);
        }


    }
}
