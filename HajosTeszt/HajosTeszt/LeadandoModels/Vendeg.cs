using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.LeadandoModels
{
    public partial class Vendeg
    {
        public Vendeg()
        {
            Foglalas = new HashSet<Foglala>();
        }

        public string Usernev { get; set; }
        public string Nev { get; set; }
        public string Email { get; set; }
        public string SzamlCim { get; set; }
        public DateTime? SzulDat { get; set; }

        public virtual ICollection<Foglala> Foglalas { get; set; }
    }
}
