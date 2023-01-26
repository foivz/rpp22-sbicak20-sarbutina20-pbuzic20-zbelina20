using EntitiesLayer.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace DataAccessLayer
{
    public partial class ZMGBaza : DbContext
    {
        public ZMGBaza()
            : base("name=ZMGBaza")
        {
        }

        public virtual DbSet<IzvjestajKlijenata> IzvjestajKlijenata { get; set; }
        public virtual DbSet<IzvjestajRadnihNaloga> IzvjestajRadnihNaloga { get; set; }
        public virtual DbSet<Klijent> Klijent { get; set; }
        public virtual DbSet<Materijal> Materijal { get; set; }
        public virtual DbSet<Poslodavac> Poslodavac { get; set; }
        public virtual DbSet<Primka> Primka { get; set; }
        public virtual DbSet<Racun> Racun { get; set; }
        public virtual DbSet<Radnik> Radnik { get; set; }
        public virtual DbSet<RadniNalog> RadniNalog { get; set; }
        public virtual DbSet<Roba> Roba { get; set; }
        public virtual DbSet<StavkaRacun> StavkaRacun { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<Usluga> Usluga { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IzvjestajKlijenata>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<IzvjestajKlijenata>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<IzvjestajKlijenata>()
                .Property(e => e.Stvorio)
                .IsUnicode(false);

            modelBuilder.Entity<IzvjestajRadnihNaloga>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<IzvjestajRadnihNaloga>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<IzvjestajRadnihNaloga>()
                .Property(e => e.Stvorio)
                .IsUnicode(false);

            modelBuilder.Entity<IzvjestajRadnihNaloga>()
                .HasMany(e => e.RadniNalog)
                .WithMany(e => e.IzvjestajRadnihNaloga)
                .Map(m => m.ToTable("IzvjestajiSadrzeRadneNaloge").MapLeftKey("IzvjestajRadnihNaloga_ID").MapRightKey("RadniNalog_ID"));

            modelBuilder.Entity<Klijent>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Klijent>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Klijent>()
                .Property(e => e.Mjesto)
                .IsUnicode(false);

            modelBuilder.Entity<Klijent>()
                .Property(e => e.OIB)
                .IsUnicode(false);

            modelBuilder.Entity<Klijent>()
                .Property(e => e.BrojTelefona)
                .IsUnicode(false);

            modelBuilder.Entity<Klijent>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Klijent>()
                .Property(e => e.IBAN)
                .IsUnicode(false);

            modelBuilder.Entity<Materijal>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Materijal>()
                .Property(e => e.JedinicaMjere)
                .IsUnicode(false);

            modelBuilder.Entity<Materijal>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Materijal>()
                .Property(e => e.QR_kod)
                .IsUnicode(false);

            modelBuilder.Entity<Materijal>()
                .HasMany(e => e.RadniNalog)
                .WithMany(e => e.Materijal)
                .Map(m => m.ToTable("RadniNalogSadrziMaterijal").MapLeftKey("Materijal_ID").MapRightKey("RadniNalog_ID"));

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.Adresa)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.Mjesto)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.BrojTelefona)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.IBAN)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.Banka)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.UpisObrtniRegistar)
                .IsUnicode(false);

            modelBuilder.Entity<Poslodavac>()
                .Property(e => e.Poslovnica)
                .IsUnicode(false);

            modelBuilder.Entity<Primka>()
                .Property(e => e.Naziv_Materijal)
                .IsUnicode(false);

            modelBuilder.Entity<Racun>()
                .Property(e => e.Fakturirao)
                .IsUnicode(false);

            modelBuilder.Entity<Racun>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<Racun>()
                .Property(e => e.NacinPlacanja)
                .IsUnicode(false);

            modelBuilder.Entity<Racun>()
                .HasMany(e => e.StavkaRacun)
                .WithRequired(e => e.Racun)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.Ime)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.Prezime)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.Korime)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.Lozinka)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.OIB)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.BrojTelefona)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Radnik>()
                .HasMany(e => e.IzvjestajKlijenata)
                .WithRequired(e => e.Radnik)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<RadniNalog>()
                .Property(e => e.Opis)
                .IsUnicode(false);

            modelBuilder.Entity<RadniNalog>()
                .Property(e => e.QR_kod)
                .IsUnicode(false);

            modelBuilder.Entity<RadniNalog>()
                .Property(e => e.Status)
                .IsUnicode(false);

            modelBuilder.Entity<Roba>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Roba>()
                .Property(e => e.Kolicina)
                .IsUnicode(false);

            modelBuilder.Entity<Roba>()
                .HasMany(e => e.StavkaRacun)
                .WithRequired(e => e.Roba)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<StavkaRacun>()
                .Property(e => e.JedinicaMjere)
                .IsUnicode(false);

            modelBuilder.Entity<Usluga>()
                .Property(e => e.Naziv)
                .IsUnicode(false);

            modelBuilder.Entity<Usluga>()
                .Property(e => e.QR_kod)
                .IsUnicode(false);

            modelBuilder.Entity<Usluga>()
                .HasMany(e => e.StavkaRacun)
                .WithRequired(e => e.Usluga)
                .WillCascadeOnDelete(false);
        }
    }
}
