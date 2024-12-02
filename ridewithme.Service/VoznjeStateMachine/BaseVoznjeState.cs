using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Service.Database;

using Microsoft.Extensions.DependencyInjection;


namespace ridewithme.Service.VoznjeStateMachine
{
    public class BaseVoznjeState
    {
        public RidewithmeContext Context { get; set; }

        public IMapper Mapper { get; set; }

        public IServiceProvider ServiceProvider { get; set; }
        public BaseVoznjeState(RidewithmeContext dbContext, IMapper mapper, IServiceProvider serviceProvider)
        {
            Context = dbContext;
            Mapper = mapper;
            ServiceProvider = serviceProvider;
        }
        public virtual Model.Voznje Insert(VoznjeInsertRequest request)
        {
            throw new Exception("Method not allowed");
        }

        public virtual Model.Voznje Update(int id, VoznjeUpdateRequest request)
        { 
            throw new Exception("Method not allowed");
        }

        public virtual Model.Voznje Activate(int id)
        {
            throw new Exception("Method not allowed");
        }
        public virtual Model.Voznje Hide(int id)
        {
            throw new Exception("Method not allowed");
        }
        public virtual Model.Voznje Edit(int id)
        {
            throw new Exception("Method not allowed");
        }

        public virtual List<string> AllowedActions(Database.Voznje entity)
        {
            throw new Exception("Method not allowed");
        }

        public BaseVoznjeState CreateState(string stateName)
        {
            switch (stateName)
            {
                case "initial":
                    return ServiceProvider.GetService<InitialVoznjeState>();

                case "draft":
                    return ServiceProvider.GetService<DraftVoznjeState>();

                case "active":
                    return ServiceProvider.GetService<ActiveVoznjeState>();

                case "hidden":
                    return ServiceProvider.GetService<HiddenVoznjeState>();

                default: throw new Exception("State not recognized.");
            }
        }
    }
}

//Initial, draft, active, hidden -> active