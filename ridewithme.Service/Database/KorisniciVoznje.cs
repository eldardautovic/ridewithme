using ridewithme.Model;
using ridewithme.Service.Migrations;
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

        public Korisnici Korisnik { get; set; }
        public Voznje Voznja { get; set; }
    }
}
