﻿using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Service.Database;

using Microsoft.Extensions.DependencyInjection;
using ridewithme.Model;


namespace ridewithme.Service.ZalbeStateMachine
{
    public class BaseZalbeState
    {
        public RidewithmeContext Context { get; set; }

        public IMapper Mapper { get; set; }

        public IServiceProvider ServiceProvider { get; set; }
        public BaseZalbeState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider)
        {
            Context = dbContext;
            Mapper = mapper;
            ServiceProvider = serviceProvider;
        }
        public virtual Model.Zalbe Insert(ZalbeInsertRequest request)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Zalbe Activate(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Zalbe Complete(int id, ZalbeCompleteRequest request)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Zalbe Update(int id, ZalbeUpdateRequest request)
        { 
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual string Delete(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Zalbe Processing(int id, int administratorId)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual List<string> AllowedActions(Database.Zalbe entity)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public BaseZalbeState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return ServiceProvider.GetService<InitialZalbeState>();

                case "active":
                    return ServiceProvider.GetService<ActiveZalbeState>();

                case "processing":
                    return ServiceProvider.GetService<ProcessingZalbeState>();

                case "completed":
                    return ServiceProvider.GetService<CompletedZalbeState>();

                default: throw new Exception("State not recognized.");
            }
        }
    }
}

//Initial, draft, active, hidden -> active -> used