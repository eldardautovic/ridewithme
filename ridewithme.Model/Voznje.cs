using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public class Voznje
    {
        public int Id { get; set; }

        public int VozacId { get; set; }

        public int? KlijentId { get; set; }

        public DateTime DatumVrijemePocetka { get; set; }

        public DateTime? DatumVrijemeZavrsetka { get; set; }

        public string? StateMachine  { get; set; }

    }
}
