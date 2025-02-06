using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public class KorisniciDostignuca
    {
        public int Id { get; set; }

        public virtual Dostignuca Dostignuce { get; set; }

        public DateTime DatumKreiranja { get; set; }
    }
}
