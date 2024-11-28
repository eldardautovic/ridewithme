using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model.SearchObject
{
    public class VoznjeSearchObject : BaseSearchObject
    {
        public int? VoznjaId { get; set; }

        public int? KlijentId { get; set; }

        public DateTime? DatumVrijemePocetka { get; set; }

        public DateTime? DatumVrijemeZavrsetka { get; set; }

    }
}
