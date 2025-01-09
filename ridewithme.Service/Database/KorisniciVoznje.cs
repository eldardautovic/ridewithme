using ridewithme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ridewithme.Service.Database
{
    public partial class KorisniciVoznje
    {
        public int Id { get; set; } 
        public int KorisnikId { get; set; }
        public int VoznjaId { get; set; } 
        public bool Klijent { get; set; } 
        public bool Vozac { get; set; } 

        public virtual Korisnici Korisnik { get; set; } = null!;
        public virtual Voznje Voznja { get; set; } = null!;
    }
}
