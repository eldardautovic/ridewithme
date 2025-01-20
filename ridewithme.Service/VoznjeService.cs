using Azure.Core;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
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

            if(searchObject?.IsVoznjaActivated == true)
            {
                filteredQuery = filteredQuery.Where(x => x.StateMachine == "active");
            }

            if (searchObject?.IsKorisniciIncluded == true)
            {
                filteredQuery = filteredQuery.Include(x => x.Klijent);

                filteredQuery = filteredQuery.Include(x => x.Vozac);

            }

            if (searchObject?.IsGradoviIncluded == true)
            {
                filteredQuery = filteredQuery.Include(x => x.GradOd);

                filteredQuery = filteredQuery.Include(x => x.GradDo);
            }

            if(searchObject?.GradDoId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.GradDoId == searchObject.GradDoId.Value);
            }

            if (searchObject?.GradOdId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.GradOdId == searchObject.GradOdId.Value);
            }

            filteredQuery =  filteredQuery.Include(x => x.Dogadjaj);

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

        public string Delete(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Delete(id);
        }

        public Model.Voznje Rate(int id, int ocjena)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Rate(id, ocjena);
        }

        public Model.Voznje Book(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Book(id);
        }

        public List<string> AllowedActions(int id)
        {
            if(id <= 0)
            {
                var state = BaseVoznjeState.CreateState("initial");
                return state.AllowedActions(null);
            }
            else
            {
                var entity = Context.Voznje.Find(id);
                var state = BaseVoznjeState.CreateState(entity.StateMachine);
                return state.AllowedActions(entity);
            }
        }

        public List<Model.Korisnici> GetParticipants(int id)
        {
            return new List<Model.Korisnici>();
        }
    }
}
