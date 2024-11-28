using System;
using System.Collections.Generic;

namespace ridewithme.Model.Requests
{
    public class VoznjeInsertRequest
    {
        public int VozacId { get; set; }

        public int? KlijentId { get; set; }

        public DateTime DatumVrijemePocetka { get; set; }

        public DateTime? DatumVrijemeZavrsetka { get; set; }
    }
}
