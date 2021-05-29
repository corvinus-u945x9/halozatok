using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.LeadandoModels
{
    public partial class Szoba
    {
        public Szoba()
        {
            Foglalas = new HashSet<Foglala>();
        }

        public int SzobaId { get; set; }
        public string SzobaSzama { get; set; }
        public int Ferohely { get; set; }
        public int? Potagy { get; set; }
        public string Klimas { get; set; }
        public int? SzallasFk { get; set; }

        public virtual Szallashely SzallasFkNavigation { get; set; }
        public virtual ICollection<Foglala> Foglalas { get; set; }
    }
}
