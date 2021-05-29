using System;
using System.Collections.Generic;

#nullable disable

namespace HajosTeszt.LeadandoModels
{
    public partial class Foglala
    {
        public int FoglalasPk { get; set; }
        public string UgyfelFk { get; set; }
        public int SzobaFk { get; set; }
        public DateTime Mettol { get; set; }
        public DateTime Meddig { get; set; }
        public int FelnottSzam { get; set; }
        public int GyermekSzam { get; set; }

        public virtual Szoba SzobaFkNavigation { get; set; }
        public virtual Vendeg UgyfelFkNavigation { get; set; }
    }
}
