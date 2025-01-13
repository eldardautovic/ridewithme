using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model.SearchObject
{
    public class ZalbeSearchObject : BaseSearchObject
    {
        public string? NaslovGTE { get; set; }

        public string? SadrzajGTE { get; set; }

        public DateTime? DatumPreuzimanja { get; set; }
        public DateTime? DatumIzmjene { get; set; }
        public DateTime? DatumKreiranja { get; set; }

        public string? VrstaZalbe { get; set; }

        public int? AdministratorId { get; set; }

        public int? KorisnikId { get; set; }

        public bool? IsKorisnikIncluded { get; set; }

        public bool? IsAdministratorIncluded { get; set; }

        public bool? IsVrstaZalbeIncluded { get; set; }

    }
}
