using System;
using System.Collections.Generic;

namespace ridewithme.Service.Database;

public partial class Korisnici
{
    public int Id { get; set; }

    public string Ime { get; set; } = null!;

    public string Prezime { get; set; } = null!;

    public string KorisnickoIme { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string LozinkaHash { get; set; }

    public string LozinkaSalt { get; set; }

    public DateTime? DatumKreiranja { get; set; }

    public virtual ICollection<KorisniciUloge> KorisniciUloge { get; set; } = new List<KorisniciUloge>();

    public virtual ICollection<Voznje> VoznjeKlijents { get; set; } = new List<Voznje>();

    public virtual ICollection<Voznje> VoznjeVozacs { get; set; } = new List<Voznje>();
}
