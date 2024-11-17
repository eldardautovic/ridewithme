using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public class Voznje
    {
        public int VoznjaId { get; set; }

        public DateTime DatumVrijemePocetka { get; set; }

        public DateTime? DatumVrijemeZavrsetka { get; set; }

    }
}
