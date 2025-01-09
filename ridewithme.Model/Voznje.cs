using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public class Voznje
    {
        public int Id { get; set; }

        public string StateMachine { get; set; }

        public DateTime DatumVrijemePocetka { get; set; }

        public DateTime? DatumVrijemeZavrsetka { get; set; }

        public virtual ICollection<KorisniciVoznje> KorisniciVoznje { get; set; }

    }
}
