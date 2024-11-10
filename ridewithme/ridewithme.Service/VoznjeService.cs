using ridewithme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service
{
    public class VoznjeService : IVoznjeService
    {
        public List<Voznje> List = new List<Voznje>()
        {
            new Voznje()
            {
                VoznjaId = 1,
                Cijena = 10,
                Destinacija = "Elce"
            }
        };
        public List<Voznje> GetList()
        {
            return List;
        }
    }
}
