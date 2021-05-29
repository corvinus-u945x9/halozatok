using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace HajosTeszt.LeadandoModels
{
    public partial class SzamhaloContext : DbContext
    {
        public SzamhaloContext()
        {
        }

        public SzamhaloContext(DbContextOptions<SzamhaloContext> options)
            : base(options)
        {
        }

        public virtual DbSet<A29z1n> A29z1ns { get; set; }
        public virtual DbSet<A5n4oj> A5n4ojs { get; set; }
        public virtual DbSet<A5rh9c> A5rh9cs { get; set; }
        public virtual DbSet<Aoad9f> Aoad9fs { get; set; }
        public virtual DbSet<Aqxpov> Aqxpovs { get; set; }
        public virtual DbSet<Btbl7l> Btbl7ls { get; set; }
        public virtual DbSet<Bwneoj> Bwneojs { get; set; }
        public virtual DbSet<CsergoDaniel> CsergoDaniels { get; set; }
        public virtual DbSet<D1zo8l> D1zo8ls { get; set; }
        public virtual DbSet<D8apkd> D8apkds { get; set; }
        public virtual DbSet<Ecln4q> Ecln4qs { get; set; }
        public virtual DbSet<Ed4c4c> Ed4c4cs { get; set; }
        public virtual DbSet<Epnxjj> Epnxjjs { get; set; }
        public virtual DbSet<Ewhn1v> Ewhn1vs { get; set; }
        public virtual DbSet<Fa6ybv> Fa6ybvs { get; set; }
        public virtual DbSet<Fhk6hb> Fhk6hbs { get; set; }
        public virtual DbSet<Fkjbel> Fkjbels { get; set; }
        public virtual DbSet<Foglala> Foglalas { get; set; }
        public virtual DbSet<G9aktc> G9aktcs { get; set; }
        public virtual DbSet<Gkkojw> Gkkojws { get; set; }
        public virtual DbSet<Gs3gne> Gs3gnes { get; set; }
        public virtual DbSet<Gsqrbp> Gsqrbps { get; set; }
        public virtual DbSet<I866wf> I866wfs { get; set; }
        public virtual DbSet<Iknj5b> Iknj5bs { get; set; }
        public virtual DbSet<Ink87> Ink87s { get; set; }
        public virtual DbSet<Iz7tl4> Iz7tl4s { get; set; }
        public virtual DbSet<Jp8spz> Jp8spzs { get; set; }
        public virtual DbSet<Keresznev> Keresznevs { get; set; }
        public virtual DbSet<Khtnnc> Khtnncs { get; set; }
        public virtual DbSet<Lkx2mo> Lkx2mos { get; set; }
        public virtual DbSet<N0adbr> N0adbrs { get; set; }
        public virtual DbSet<N4zx1u> N4zx1us { get; set; }
        public virtual DbSet<O8xp5z> O8xp5zs { get; set; }
        public virtual DbSet<P87v9a> P87v9as { get; set; }
        public virtual DbSet<P97bbn> P97bbns { get; set; }
        public virtual DbSet<Rv5qb9> Rv5qb9s { get; set; }
        public virtual DbSet<Szallashely> Szallashelies { get; set; }
        public virtual DbSet<Szoba> Szobas { get; set; }
        public virtual DbSet<T509zq> T509zqs { get; set; }
        public virtual DbSet<Table> Tables { get; set; }
        public virtual DbSet<Thuf0b> Thuf0bs { get; set; }
        public virtual DbSet<Tqc5ox> Tqc5oxes { get; set; }
        public virtual DbSet<U945x9> U945x9s { get; set; }
        public virtual DbSet<Vendeg> Vendegs { get; set; }
        public virtual DbSet<Wnxao6> Wnxao6s { get; set; }
        public virtual DbSet<X4f6wv> X4f6wvs { get; set; }
        public virtual DbSet<Xsegpl> Xsegpls { get; set; }
        public virtual DbSet<Xswy3l> Xswy3ls { get; set; }
        public virtual DbSet<Yn2fm9> Yn2fm9s { get; set; }
        public virtual DbSet<Yubqne> Yubqnes { get; set; }
        public virtual DbSet<Zenesz> Zeneszs { get; set; }
        public virtual DbSet<Zgtpmn> Zgtpmns { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=bit.uni-corvinus.hu;Initial Catalog=Szamhalo;User ID=szamhalo;Password=keszulaleadando");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Hungarian_CI_AS");

            modelBuilder.Entity<A29z1n>(entity =>
            {
                entity.HasKey(e => e.EtteremId);

                entity.ToTable("A29Z1N");

                entity.Property(e => e.EtteremId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Etterem_ID");

                entity.Property(e => e.EtteremNev)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Etterem_Nev");
            });

            modelBuilder.Entity<A5n4oj>(entity =>
            {
                entity.HasKey(e => e.KonyvId);

                entity.ToTable("A5N4OJ");

                entity.Property(e => e.KonyvId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("konyvID");

                entity.Property(e => e.Konyvnev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("konyvnev");
            });

            modelBuilder.Entity<A5rh9c>(entity =>
            {
                entity.HasKey(e => e.MovieId);

                entity.ToTable("A5RH9C");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.Title).HasMaxLength(100);
            });

            modelBuilder.Entity<Aoad9f>(entity =>
            {
                entity.HasKey(e => e.DinoId)
                    .HasName("PK_aoad9f");

                entity.ToTable("AOAD9F");

                entity.Property(e => e.DinoId).HasColumnName("dinoID");

                entity.Property(e => e.Dinonev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("dinonev");
            });

            modelBuilder.Entity<Aqxpov>(entity =>
            {
                entity.HasKey(e => e.CimId)
                    .HasName("PK__AQXPOV__3214EC07B8A3A203");

                entity.ToTable("AQXPOV");

                entity.Property(e => e.CimId).HasColumnName("Cim_id");

                entity.Property(e => e.Cim).HasMaxLength(255);
            });

            modelBuilder.Entity<Btbl7l>(entity =>
            {
                entity.ToTable("BTBL7L");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Film)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Bwneoj>(entity =>
            {
                entity.ToTable("BWNEOJ");

                entity.Property(e => e.Id)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ID");

                entity.Property(e => e.Modell).HasMaxLength(50);

                entity.Property(e => e.Márka).HasMaxLength(50);
            });

            modelBuilder.Entity<CsergoDaniel>(entity =>
            {
                entity.ToTable("CsergoDaniel");

                entity.Property(e => e.Név).HasMaxLength(50);
            });

            modelBuilder.Entity<D1zo8l>(entity =>
            {
                entity.HasKey(e => e.ParkoloTipusId);

                entity.ToTable("D1ZO8L");

                entity.Property(e => e.ParkoloTipusId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("ParkoloTipusID");

                entity.Property(e => e.ParkoloTipus).HasMaxLength(20);
            });

            modelBuilder.Entity<D8apkd>(entity =>
            {
                entity.HasKey(e => e.SzalonId);

                entity.ToTable("D8APKD");

                entity.Property(e => e.SzalonId).HasColumnName("Szalon_ID");

                entity.Property(e => e.SzalonNev)
                    .IsRequired()
                    .HasMaxLength(30)
                    .HasColumnName("Szalon_Nev");
            });

            modelBuilder.Entity<Ecln4q>(entity =>
            {
                entity.HasKey(e => e.SorozatokId)
                    .HasName("PK__ECLN4Q__15178548BDF02627");

                entity.ToTable("ECLN4Q");

                entity.Property(e => e.SorozatokId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SorozatokID");

                entity.Property(e => e.Sorozatoknev)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            modelBuilder.Entity<Ed4c4c>(entity =>
            {
                entity.HasKey(e => e.NevSk);

                entity.ToTable("ED4C4C");

                entity.Property(e => e.NevSk).HasColumnName("Nev_SK");

                entity.Property(e => e.Csillagjegy).HasMaxLength(50);

                entity.Property(e => e.Nev).HasMaxLength(50);
            });

            modelBuilder.Entity<Epnxjj>(entity =>
            {
                entity.HasKey(e => e.VersenyzoId)
                    .HasName("PK__EPNXJJ__E6AA32CE8EBA4452");

                entity.ToTable("EPNXJJ");

                entity.Property(e => e.VersenyzoId).HasColumnName("versenyzoID");

                entity.Property(e => e.Nem)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("nem");

                entity.Property(e => e.Nemzetiseg)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nemzetiseg");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("nev");

                entity.Property(e => e.Szulido)
                    .HasColumnType("date")
                    .HasColumnName("szulido");
            });

            modelBuilder.Entity<Ewhn1v>(entity =>
            {
                entity.HasKey(e => e.ÜgyfélSk);

                entity.ToTable("EWHN1V");

                entity.Property(e => e.ÜgyfélSk).HasColumnName("Ügyfél_SK");

                entity.Property(e => e.Cím).HasMaxLength(100);

                entity.Property(e => e.Név)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.SzületésiÉv).HasColumnName("Születési_év");
            });

            modelBuilder.Entity<Fa6ybv>(entity =>
            {
                entity.HasKey(e => e.MadarSk);

                entity.ToTable("FA6YBV");

                entity.Property(e => e.MadarSk).HasColumnName("madarSK");

                entity.Property(e => e.MadarNev).HasColumnName("madarNev");
            });

            modelBuilder.Entity<Fhk6hb>(entity =>
            {
                entity.ToTable("FHK6HB");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Fkjbel>(entity =>
            {
                entity.HasKey(e => e.AutoId)
                    .HasName("PK_FKJBEL");

                entity.ToTable("fkjbel");

                entity.Property(e => e.AutoId).HasColumnName("autoID");

                entity.Property(e => e.AutoNev)
                    .HasMaxLength(30)
                    .HasColumnName("autoNev");
            });

            modelBuilder.Entity<Foglala>(entity =>
            {
                entity.HasKey(e => e.FoglalasPk);

                entity.Property(e => e.FoglalasPk)
                    .ValueGeneratedNever()
                    .HasColumnName("FOGLALAS_PK");

                entity.Property(e => e.FelnottSzam).HasColumnName("FELNOTT_SZAM");

                entity.Property(e => e.GyermekSzam).HasColumnName("GYERMEK_SZAM");

                entity.Property(e => e.Meddig)
                    .HasColumnType("date")
                    .HasColumnName("MEDDIG");

                entity.Property(e => e.Mettol)
                    .HasColumnType("date")
                    .HasColumnName("METTOL");

                entity.Property(e => e.SzobaFk).HasColumnName("SZOBA_FK");

                entity.Property(e => e.UgyfelFk)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("UGYFEL_FK");

                entity.HasOne(d => d.SzobaFkNavigation)
                    .WithMany(p => p.Foglalas)
                    .HasForeignKey(d => d.SzobaFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foglalas_Szoba");

                entity.HasOne(d => d.UgyfelFkNavigation)
                    .WithMany(p => p.Foglalas)
                    .HasForeignKey(d => d.UgyfelFk)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Foglalas_Vendeg");
            });

            modelBuilder.Entity<G9aktc>(entity =>
            {
                entity.ToTable("g9aktc");

                entity.Property(e => e.Csapatnév).HasMaxLength(50);
            });

            modelBuilder.Entity<Gkkojw>(entity =>
            {
                entity.HasKey(e => e.MemeId)
                    .HasName("PK__GKKOJW__83FFA7860B4D1E36");

                entity.ToTable("GKKOJW");

                entity.Property(e => e.MemeId).HasColumnName("MemeID");

                entity.Property(e => e.MemeText)
                    .IsRequired()
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Gs3gne>(entity =>
            {
                entity.ToTable("GS3GNE");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Termek)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("termek");
            });

            modelBuilder.Entity<Gsqrbp>(entity =>
            {
                entity.ToTable("GSQRBP");

                entity.Property(e => e.DueDate).HasColumnType("date");

                entity.Property(e => e.Text).HasMaxLength(100);
            });

            modelBuilder.Entity<I866wf>(entity =>
            {
                entity.ToTable("I866WF");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Név).HasMaxLength(50);

                entity.Property(e => e.Telefonszám)
                    .HasMaxLength(12)
                    .HasColumnName("telefonszám");
            });

            modelBuilder.Entity<Iknj5b>(entity =>
            {
                entity.HasKey(e => e.TortenetSk);

                entity.ToTable("IKNJ5B");

                entity.Property(e => e.TortenetSk).HasColumnName("TortenetSK");

                entity.Property(e => e.TortenetSzemely)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TortenetSzoveg)
                    .IsRequired()
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<Ink87>(entity =>
            {
                entity.HasKey(e => e.ZenekarId)
                    .HasName("PK__INK87S__51EE66BAEB3ABBD2");

                entity.ToTable("INK87S");

                entity.Property(e => e.ZenekarId)
                    .ValueGeneratedNever()
                    .HasColumnName("Zenekar_ID");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Iz7tl4>(entity =>
            {
                entity.HasKey(e => e.KutyaId)
                    .HasName("PK__IZ7TL4__2C1CF9ABB5466FF6");

                entity.ToTable("IZ7TL4");

                entity.Property(e => e.KutyaId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("KutyaID");

                entity.Property(e => e.Fajta).HasMaxLength(50);

                entity.Property(e => e.Nem).HasMaxLength(5);

                entity.Property(e => e.Név).HasMaxLength(50);
            });

            modelBuilder.Entity<Jp8spz>(entity =>
            {
                entity.ToTable("JP8SPZ");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Sorozatnev)
                    .HasMaxLength(100)
                    .HasColumnName("sorozatnev")
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Keresznev>(entity =>
            {
                entity.HasKey(e => e.NevId)
                    .HasName("PK__Kereszne__11251819D01284E3");

                entity.ToTable("Keresznev");

                entity.Property(e => e.NevId).HasColumnName("nevID");

                entity.Property(e => e.Keresztnev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("keresztnev");
            });

            modelBuilder.Entity<Khtnnc>(entity =>
            {
                entity.ToTable("KHTNNC");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Sportag)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Lkx2mo>(entity =>
            {
                entity.ToTable("LKX2MO");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Klub)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<N0adbr>(entity =>
            {
                entity.HasKey(e => e.KajaSk);

                entity.ToTable("N0ADBR");

                entity.Property(e => e.KajaSk).HasColumnName("KajaSK");

                entity.Property(e => e.Kaja).HasMaxLength(50);

                entity.Property(e => e.Nev).HasMaxLength(50);
            });

            modelBuilder.Entity<N4zx1u>(entity =>
            {
                entity.ToTable("N4ZX1U");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ElkeszitesiIdo)
                    .HasMaxLength(10)
                    .HasColumnName("Elkeszitesi_ido")
                    .IsFixedLength(true);

                entity.Property(e => e.Kaloria).HasMaxLength(20);

                entity.Property(e => e.Megnevezes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<O8xp5z>(entity =>
            {
                entity.HasKey(e => e.Filmid);

                entity.ToTable("O8XP5Z");

                entity.Property(e => e.Filmid).ValueGeneratedOnAdd();

                entity.Property(e => e.Filmcim)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<P87v9a>(entity =>
            {
                entity.ToTable("P87V9A");

                entity.Property(e => e.Étel).HasMaxLength(50);
            });

            modelBuilder.Entity<P97bbn>(entity =>
            {
                entity.HasKey(e => e.TelefonSk)
                    .HasName("PK_Telefon");

                entity.ToTable("P97BBN");

                entity.Property(e => e.TelefonSk).HasColumnName("TelefonSK");

                entity.Property(e => e.AvsI)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Típus).HasMaxLength(50);
            });

            modelBuilder.Entity<Rv5qb9>(entity =>
            {
                entity.ToTable("RV5QB9");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Movie)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Szallashely>(entity =>
            {
                entity.HasKey(e => e.SzallasId);

                entity.ToTable("Szallashely");

                entity.Property(e => e.SzallasId)
                    .ValueGeneratedNever()
                    .HasColumnName("SZALLAS_ID");

                entity.Property(e => e.Cim)
                    .HasMaxLength(100)
                    .HasColumnName("CIM");

                entity.Property(e => e.CsillagokSzama).HasColumnName("CSILLAGOK_SZAMA");

                entity.Property(e => e.Hely)
                    .HasMaxLength(20)
                    .HasColumnName("HELY");

                entity.Property(e => e.RogzIdo)
                    .HasColumnType("date")
                    .HasColumnName("ROGZ_IDO");

                entity.Property(e => e.Rogzitette)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("ROGZITETTE");

                entity.Property(e => e.SzallasNev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("SZALLAS_NEV");

                entity.Property(e => e.Tipus)
                    .HasMaxLength(50)
                    .HasColumnName("TIPUS");
            });

            modelBuilder.Entity<Szoba>(entity =>
            {
                entity.ToTable("Szoba");

                entity.Property(e => e.SzobaId)
                    .ValueGeneratedNever()
                    .HasColumnName("SZOBA_ID");

                entity.Property(e => e.Ferohely).HasColumnName("FEROHELY");

                entity.Property(e => e.Klimas)
                    .HasMaxLength(1)
                    .HasColumnName("KLIMAS");

                entity.Property(e => e.Potagy).HasColumnName("POTAGY");

                entity.Property(e => e.SzallasFk).HasColumnName("SZALLAS_FK");

                entity.Property(e => e.SzobaSzama)
                    .IsRequired()
                    .HasMaxLength(20)
                    .HasColumnName("SZOBA_SZAMA");

                entity.HasOne(d => d.SzallasFkNavigation)
                    .WithMany(p => p.Szobas)
                    .HasForeignKey(d => d.SzallasFk)
                    .HasConstraintName("FK_Szoba_Szallashely");
            });

            modelBuilder.Entity<T509zq>(entity =>
            {
                entity.HasKey(e => e.Sk);

                entity.ToTable("T509ZQ");

                entity.Property(e => e.Sk).HasColumnName("SK");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Table>(entity =>
            {
                entity.HasKey(e => e.ZenekarId)
                    .HasName("PK__Table__51EE66BAA4BB8990");

                entity.ToTable("Table");

                entity.Property(e => e.ZenekarId)
                    .ValueGeneratedNever()
                    .HasColumnName("Zenekar_ID");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Thuf0b>(entity =>
            {
                entity.HasKey(e => e.AutoId);

                entity.ToTable("THUF0B");

                entity.Property(e => e.AutoId).HasColumnName("autoID");

                entity.Property(e => e.AutomarkaNev)
                    .IsRequired()
                    .HasMaxLength(15)
                    .HasColumnName("automarkaNev");
            });

            modelBuilder.Entity<Tqc5ox>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TQC5OX");

                entity.Property(e => e.Title).HasMaxLength(50);

                entity.Property(e => e.TitleId).HasColumnName("TitleID");
            });

            modelBuilder.Entity<U945x9>(entity =>
            {
                entity.HasKey(e => e.NévSk);

                entity.ToTable("U945X9");

                entity.Property(e => e.NévSk).HasColumnName("Név_SK");

                entity.Property(e => e.Ital).HasMaxLength(20);

                entity.Property(e => e.Név).HasMaxLength(20);
            });

            modelBuilder.Entity<Vendeg>(entity =>
            {
                entity.HasKey(e => e.Usernev);

                entity.ToTable("Vendeg");

                entity.Property(e => e.Usernev)
                    .HasMaxLength(20)
                    .HasColumnName("USERNEV");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(60)
                    .HasColumnName("EMAIL");

                entity.Property(e => e.Nev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("NEV");

                entity.Property(e => e.SzamlCim)
                    .HasMaxLength(100)
                    .HasColumnName("SZAML_CIM");

                entity.Property(e => e.SzulDat)
                    .HasColumnType("date")
                    .HasColumnName("SZUL_DAT");
            });

            modelBuilder.Entity<Wnxao6>(entity =>
            {
                entity.HasKey(e => e.SkTarot);

                entity.ToTable("WNXAO6");

                entity.Property(e => e.SkTarot)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("SK_tarot");

                entity.Property(e => e.Tarotszoveg)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<X4f6wv>(entity =>
            {
                entity.HasKey(e => e.JatekosId);

                entity.ToTable("X4F6WV");

                entity.Property(e => e.JatekosId)
                    .ValueGeneratedOnAdd()
                    .HasColumnName("Jatekos_ID");

                entity.Property(e => e.JatekosNev)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Jatekos_Nev");
            });

            modelBuilder.Entity<Xsegpl>(entity =>
            {
                entity.HasKey(e => e.VizipipadohanyId);

                entity.ToTable("XSEGPL");

                entity.Property(e => e.VizipipadohanyId).HasColumnName("VizipipadohanyID");

                entity.Property(e => e.VizipipaDohanyNeve)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Vizipipa dohany neve");
            });

            modelBuilder.Entity<Xswy3l>(entity =>
            {
                entity.ToTable("XSWY3L");

                entity.Property(e => e.Italok).HasMaxLength(50);
            });

            modelBuilder.Entity<Yn2fm9>(entity =>
            {
                entity.HasKey(e => e.SongId);

                entity.ToTable("YN2FM9");

                entity.Property(e => e.SongId).HasColumnName("songID");

                entity.Property(e => e.SongOwner)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("songOwner");

                entity.Property(e => e.SongTitle)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("songTitle");
            });

            modelBuilder.Entity<Yubqne>(entity =>
            {
                entity.HasKey(e => e.KocsmaId)
                    .HasName("PK__YUBQNE__08A2B8F718829509");

                entity.ToTable("YUBQNE");

                entity.Property(e => e.KocsmaId)
                    .HasColumnType("decimal(3, 0)")
                    .HasColumnName("Kocsma_ID");

                entity.Property(e => e.KocsmaNev)
                    .IsRequired()
                    .HasMaxLength(200);
            });

            modelBuilder.Entity<Zenesz>(entity =>
            {
                entity.ToTable("Zenesz");

                entity.Property(e => e.ZeneszId).ValueGeneratedOnAdd();

                entity.Property(e => e.Name).HasMaxLength(60);
            });

            modelBuilder.Entity<Zgtpmn>(entity =>
            {
                entity.HasKey(e => e.LoId);

                entity.ToTable("ZGTPMN");

                entity.Property(e => e.LoId).HasColumnName("loID");

                entity.Property(e => e.Lofajta)
                    .HasMaxLength(50)
                    .HasColumnName("lofajta");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
