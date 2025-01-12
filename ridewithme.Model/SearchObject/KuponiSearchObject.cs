using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model.SearchObject
{
    public class KuponiSearchObject : BaseSearchObject
    {
        public int? KuponId { get; set; }
        public DateTime? DatumPocetka { get; set; }
        public string? Kod { get; set; }
        public string? Naziv { get; set; }
        public int? BrojIskoristivostiGTE { get; set; }
        public double? PopustGTE { get; set; }

    }
}
