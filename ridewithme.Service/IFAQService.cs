using ridewithme.Model.Requests;
using ridewithme.Model.SearchObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IFAQService : ICRUDService<Model.FAQ, FAQSearchObject, FAQInsertRequest, FAQUpdateRequest>
    {
        public Model.FAQ Delete(int id);
    }
}
