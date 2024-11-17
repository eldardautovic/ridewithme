using System;
using System.Collections.Generic;

namespace ridewithme.Service.Database;

public partial class Uloge
{
    public int Id { get; set; }

    public string Naziv { get; set; } = null!;

    public virtual ICollection<Korisnici> Korisnicis { get; set; } = new List<Korisnici>();
}
