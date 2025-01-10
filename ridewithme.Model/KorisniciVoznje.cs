using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public partial class KorisniciVoznje
    {
        public int Id { get; set; }
        public int VoznjaId { get; set; }
        public bool Vozac { get; set; }
        public virtual Voznje Voznja { get; set; } = null!;
    }
}
