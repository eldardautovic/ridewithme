using MapsterMapper;
using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IObavjestenjaService : ICRUDService<Model.Obavjestenja, ObavjestenjaSearchObject, ObavjestenjaInsertRequest, ObavjestenjaUpdateRequest>
    {
        public List<string> AllowedActions(int id);
        public Model.Obavjestenja Activate(int id);
        public Model.Obavjestenja Hide(int id);
        public Model.Obavjestenja Edit(int id);
        public Model.Obavjestenja Delete(int id);
        public Model.Obavjestenja Complete(int id);

    }
}
