using ridewithme.Model;
using ridewithme.Model.SearchObject;
using ridewithme.Model.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IKuponiService : ICRUDService<Kuponi, KuponiSearchObject, KuponiInsertRequest, KuponiUpdateRequest>
    {
        public Kuponi Activate(int id);
        public Kuponi Hide(int id);
        public Kuponi Edit(int id);
        public List<string> AllowedActions(int id);
    }
}
