using ridewithme.Model;
using ridewithme.Model.SearchObject;
using ridewithme.Service.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public interface IKorisniciService
    {
        List<Model.Korisnici> GetList(KorisniciSearchObject searchObject);

        Model.Korisnici Insert(Model.Requests.KorisniciInsertRequest request);
    }
}
