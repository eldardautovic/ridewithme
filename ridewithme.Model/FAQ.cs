using System;
using System.Collections.Generic;
using System.Text;

namespace ridewithme.Model
{
    public class FAQ
    {
        public int Id { get; set; }

        public string Pitanje { get; set; }

        public string Odgovor { get; set; }

        public DateTime DatumKreiranja { get; set; }

        public DateTime DatumIzmjene { get; set; }

        public Korisnici Korisnik { get; set; }
    }
}
