﻿using Azure.Core;
using MapsterMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using ridewithme.Service.VoznjeStateMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Dynamic.Core;
using ridewithme.Service.Interfaces;


namespace ridewithme.Service.Services
{
    public class VoznjeService : BaseCRUDService<Model.Models.Voznje, VoznjeSearchObject, Database.Voznje, VoznjeInsertRequest, VoznjeUpdateRequest>, IVoznjeService
    {
        public BaseVoznjeState BaseVoznjeState { get; set; }

        public VoznjeService(RidewithmeContext dbContext, IMapper mapper, BaseVoznjeState baseVoznjeState)
            : base(dbContext, mapper)
        {
            BaseVoznjeState = baseVoznjeState;
        }

        public override IQueryable<Database.Voznje> AddFilter(VoznjeSearchObject searchObject, IQueryable<Database.Voznje> query)
        {

            var filteredQuery = base.AddFilter(searchObject, query);

            if (searchObject?.VoznjaId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.Id == searchObject.VoznjaId.Value);
            }

            if (searchObject?.VozacId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.VozacId == searchObject.VozacId.Value);
            }

            if (searchObject?.KlijentId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.KlijentId == searchObject.KlijentId.Value);
            }

            if (searchObject?.IsVoznjaActivated == true)
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

            if (searchObject?.GradDoId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.GradDoId == searchObject.GradDoId.Value);
            }

            if (searchObject?.GradOdId.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.GradOdId == searchObject.GradOdId.Value);
            }

            if (searchObject?.CijenaDo.HasValue == true)
            {
                filteredQuery = filteredQuery.Where(x => x.Cijena <= searchObject.CijenaDo);
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.OrderBy))
            {
                var items = searchObject.OrderBy.Split(' ');
                if (items.Length > 2 || items.Length == 0)
                {
                    throw new ApplicationException("Mozete sortirati samo po dva polja.");
                }
                if (items.Length == 1)
                {
                    filteredQuery = filteredQuery.OrderBy("@0", searchObject.OrderBy);
                }
                else
                {
                    filteredQuery = filteredQuery.OrderBy(string.Format("{0} {1}", items[0], items[1]));
                }

            }

            if (!string.IsNullOrWhiteSpace(searchObject?.KorisnickoImeVozacGTE))
            {
                filteredQuery = filteredQuery.Where(x => x.Vozac.KorisnickoIme.Contains(searchObject.KorisnickoImeVozacGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.KorisnickoImeKlijentGTE))
            {
                filteredQuery = filteredQuery.Where(x => x.Vozac.KorisnickoIme.Contains(searchObject.KorisnickoImeKlijentGTE));
            }

            if (!string.IsNullOrWhiteSpace(searchObject?.Status))
            {
                filteredQuery = filteredQuery.Where(x => x.StateMachine == searchObject.Status);
            }


            filteredQuery = filteredQuery.Include(x => x.Dogadjaj);

            return filteredQuery;
        }

        public override Model.Models.Voznje Insert(VoznjeInsertRequest request)
        {
            var state = BaseVoznjeState.CreateState("initial");
            return state.Insert(request);
        }

        public override Model.Models.Voznje Update(int id, VoznjeUpdateRequest request)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Update(id, request);
        }

        public Model.Models.Voznje Start(int id, VoznjeStartRequest request)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Start(id, request);
        }
        public Model.Models.Voznje Complete(int id, VoznjeCompleteRequest request)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Complete(id, request);
        }

        public Model.Models.Voznje Activate(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Activate(id);
        }
        public Model.Models.Voznje Hide(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Hide(id);
        }

        public Model.Models.Voznje Edit(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Edit(id);
        }

        public Model.Models.Voznje Delete(int id)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Delete(id);
        }

        public Model.Models.Voznje Rate(int id, int ocjena)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Rate(id, ocjena);
        }

        public Model.Models.Voznje Book(int id, VoznjeBookRequest request)
        {
            var entity = GetById(id);
            var state = BaseVoznjeState.CreateState(entity.StateMachine);

            return state.Book(id, request);
        }

        public List<string> AllowedActions(int id)
        {
            if (id <= 0)
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

        public List<Model.Models.Korisnici> GetParticipants(int id)
        {
            return new List<Model.Models.Korisnici>();
        }
    }
}
