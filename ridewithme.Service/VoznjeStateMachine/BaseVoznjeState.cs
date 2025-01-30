using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Service.Database;

using Microsoft.Extensions.DependencyInjection;
using ridewithme.Model;


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
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Voznje Update(int id, VoznjeUpdateRequest request)
        { 
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Voznje Activate(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
        } 
        public virtual Model.Voznje Hide(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }
        public virtual Model.Voznje Edit(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Voznje Delete(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Voznje Rate(int id, int ocjena)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual List<string> AllowedActions(Database.Voznje entity)
        {
            throw new UserException("Metoda nije dozvoljena.");
        }

        public virtual Model.Voznje Book(int id)
        {
            throw new UserException("Metoda nije dozvoljena.");
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

                case "booked":
                    return ServiceProvider.GetService<BookedVoznjeState>();

                default: throw new Exception("State not recognized.");
            }
        }
    }
}

//Initial, draft, active, hidden -> active -> booked -> in progress -> completed