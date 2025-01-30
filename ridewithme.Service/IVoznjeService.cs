using ridewithme.Model;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IVoznjeService : ICRUDService<Voznje, VoznjeSearchObject, VoznjeInsertRequest, VoznjeUpdateRequest>
    {

        public Voznje Activate(int id);

        public Voznje Hide(int id);
        public Voznje Edit(int id);

        public Voznje Delete(int id);

        public Voznje Rate(int id, int ocjena);

        public List<string> AllowedActions(int id);

        public List<Korisnici> GetParticipants(int id);
        public Voznje Book(int id);

    }
}
