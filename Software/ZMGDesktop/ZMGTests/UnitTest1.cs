using BusinessLogicLayer.Services;
using DataAccessLayer.Iznimke;
using EntitiesLayer.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ZMGTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestiranjeDodavanjeKorisnikauBazu()
        {
            /*Kod ovog testa nakon što se izvrši test, doda se novi korisnik u bazu
            Ako ćete pokrenuti opet javit će Vam greška da test nije uspješan
            jer korisnik već postoji u bazi. Pa kako bi test bio uspješan potrebno je 
            ili izbrisati korisnika iz baze pa pokrenuti test ili tu kod objekta klijent napisati
            drugačije podatke.
            */
            KlijentServices servis = new KlijentServices();
            var klijent = new Klijent
            {
                Naziv = "Preis",
                Adresa = "Zlatar 30",
                Mjesto = "Zlatar",
                OIB = "21693125721",
                BrojTelefona = "0917261582",
                Email = "preis@gmail.com",
                IBAN = "HR2817502816521258291"
            };

            bool uspjesno = servis.Add(klijent);
            Assert.IsTrue(uspjesno == true);
        }

        [TestMethod]
        public void DohvacanjeRacunaiRadneNalogeZaKorisnika()
        {
            RadniNalogService servisNalozi = new RadniNalogService();
            RacunService servisRacuni = new RacunService();
            KlijentServices servisKlijent = new KlijentServices();

            var klijenti = servisKlijent.DohvatiKlijente();
            Klijent postojeci = klijenti.FirstOrDefault(k => k.Naziv == "Bent");
            
            var radniNalozi = servisNalozi.DohvatiRadneNalogeZaKlijenta(postojeci);
            var racuni = servisRacuni.DohvatiRacuneZaKlijenta(postojeci);
            Assert.IsTrue(radniNalozi.Count == 1 && racuni.Count == 6);
        }

        [TestMethod]
        public void BrisanjeKlijentaIzBaze()
        {
            KlijentServices servisKlijenta = new KlijentServices();
            var klijenti = servisKlijenta.DohvatiKlijente();
            var brisi = klijenti.FirstOrDefault(k => k.Naziv == "MIAZ");
            bool uspjesno = servisKlijenta.Remove(brisi);
            Assert.IsTrue(uspjesno == true);
        }

        [TestMethod]
        [ExpectedException(typeof(BrisanjeKlijentaException))]
        public void BrisanjeKlijentaKojiImaRadneNalogeiliRacune()
        {
            KlijentServices servisKlijenta = new KlijentServices();
            var klijenti = servisKlijenta.DohvatiKlijente();
            var brisi = klijenti.FirstOrDefault(k => k.Naziv == "Bent");
            servisKlijenta.Remove(brisi);
        }

        [TestMethod]
        [ExpectedException(typeof(OIBException))]
        public void DodavanjaKlijentaSVecPostojecimOIBom()
        {
            KlijentServices servisKlijenta = new KlijentServices();
            /*
             Kad se test izvrši, klijent se doda u bazu pa je potrebno obrisati tog klijenta prije nego
            se test ponovno pokrene jer inače će bacat drugu grešku.
              */
            var klijent = new Klijent
            {
                Naziv = "Preis",
                Adresa = "Zlatar 30",
                Mjesto = "Zlatar",
                OIB = "26142825271",
                BrojTelefona = "0917261582",
                Email = "preis@gmail.com",
                IBAN = "HR2817502816521258291"
            };
            servisKlijenta.Add(klijent);
        }

        [TestMethod]
        public void DohvaćanjeDesetNajboljih()
        {
            KlijentServices servisKlijenta = new KlijentServices();
            var desetNajboljih = servisKlijenta.DohvatiDesetNajboljih();
            Assert.IsTrue(desetNajboljih.Count == 10);
        }

        //TESTOVI ZA RADNE NALOGE

        [TestMethod]
        public void DodajRadniNalog_DodanRadniNalog_RadniNalogSeDodajeUBazu()
        {
            RadniNalogService servis = new RadniNalogService();
            KlijentServices servisKlijenta = new KlijentServices();
            RadnikServices servisRadnika = new RadnikServices();
            List<Materijal> materijal = new List<Materijal>();
            List<Roba> roba = new List<Roba>();

            var klijenti = servisKlijenta.DohvatiKlijente();
            var klijent = klijenti.FirstOrDefault(k => k.Klijent_ID == 3);
            var radnici = servisRadnika.DohvatiSveRadnike();
            var radnik = radnici.FirstOrDefault(r => r.Radnik_ID == 2);

            materijal.Add(new Materijal {Materijal_ID=23, Naziv = "Željezo", CijenaMaterijala=146, JedinicaMjere="kg", Kolicina=2, Opis="", OpasnoPoZivot=false, QR_kod="0Q69O3V24CQ6IE1PWXO3"});
            roba.Add(new Roba {Roba_ID=17, Naziv = "ROBA1", Kolicina = "3" });

            var radniNalog = new RadniNalog
            {
                Kolicina = 15,
                Opis = "Treba poniklati robu klijenta",
                QR_kod = "NEK1QR123KOD12345678",
                DatumStvaranja = DateTime.Now,
                Status = "Napravljen",
                Radnik_ID = 2,
                Klijent_ID = 3,
                Klijent = klijent,
                Radnik = radnik,
                Materijal = materijal,
                Roba = roba
            };

            bool uspjesno = servis.DodajRadniNalog(radniNalog);
            Assert.IsTrue(uspjesno == true);
        }

        [TestMethod]
        public void ObrisiRadniNalog_ObrisanRadniNalog_RadniNalogJeIzbrisanIzBaze()
        {
            RadniNalogService servis = new RadniNalogService();

            var radniNalozi = servis.DohvatiRadneNaloge();
            var radniNalog = radniNalozi.FirstOrDefault(r => r.QR_kod == "NEK1QR123KOD12345678");
            
            bool uspjesno = servis.ObrisiRadniNalog(radniNalog);
            Assert.IsTrue(uspjesno == true);
        }

        [TestMethod]
        [ExpectedException(typeof(MaterijalRobaException))]
        public void DodajRadniNalog_DodavanjeRadnogNalogaBezRobe_BacanjeIznimke()
        {
            RadniNalogService servis = new RadniNalogService();
            KlijentServices servisKlijenta = new KlijentServices();
            RadnikServices servisRadnika = new RadnikServices();
            List<Materijal> materijal = new List<Materijal>();
            List<Roba> roba = new List<Roba>();

            var klijenti = servisKlijenta.DohvatiKlijente();
            var klijent = klijenti.FirstOrDefault(k => k.Klijent_ID == 3);
            var radnici = servisRadnika.DohvatiSveRadnike();
            var radnik = radnici.FirstOrDefault(r => r.Radnik_ID == 2);

            materijal.Add(new Materijal { Materijal_ID = 23, Naziv = "Željezo", CijenaMaterijala = 146, JedinicaMjere = "kg", Kolicina = 2, Opis = "", OpasnoPoZivot = false, QR_kod = "0Q69O3V24CQ6IE1PWXO3" });

            var radniNalog = new RadniNalog
            {
                Kolicina = 15,
                Opis = "Treba poniklati robu klijenta",
                QR_kod = "NEK1QR123KOD12345678",
                DatumStvaranja = DateTime.Now,
                Status = "Napravljen",
                Radnik_ID = 2,
                Klijent_ID = 3,
                Klijent = klijent,
                Radnik = radnik,
                Materijal = materijal,
                Roba = roba
            };

            servis.DodajRadniNalog(radniNalog);
        }

        [TestMethod]
        [ExpectedException(typeof(MaterijalRobaException))]
        public void DodajRadniNalog_DodavanjeRadnogNalogaBezMaterijala_BacanjeIznimke()
        {
            RadniNalogService servis = new RadniNalogService();
            KlijentServices servisKlijenta = new KlijentServices();
            RadnikServices servisRadnika = new RadnikServices();
            List<Materijal> materijal = new List<Materijal>();
            List<Roba> roba = new List<Roba>();

            var klijenti = servisKlijenta.DohvatiKlijente();
            var klijent = klijenti.FirstOrDefault(k => k.Klijent_ID == 3);
            var radnici = servisRadnika.DohvatiSveRadnike();
            var radnik = radnici.FirstOrDefault(r => r.Radnik_ID == 2);

            roba.Add(new Roba { Roba_ID = 17, Naziv = "ROBA1", Kolicina = "3" });

            var radniNalog = new RadniNalog
            {
                Kolicina = 15,
                Opis = "Treba poniklati robu klijenta",
                QR_kod = "NEK1QR123KOD12345678",
                DatumStvaranja = DateTime.Now,
                Status = "Napravljen",
                Radnik_ID = 2,
                Klijent_ID = 3,
                Klijent = klijent,
                Radnik = radnik,
                Materijal = materijal,
                Roba = roba
            };

            servis.DodajRadniNalog(radniNalog);
        }
    }
}
