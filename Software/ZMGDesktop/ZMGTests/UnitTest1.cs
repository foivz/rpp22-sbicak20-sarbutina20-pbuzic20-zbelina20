using BusinessLogicLayer.LogikaZaRacune;
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
        public void ADodajKlijenta_DodavanjeKlijenta_KlijentDodanUBazu()
        {
            /*Kod ovog testa nakon što se izvrši test, doda se novi korisnik u bazu
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

        /*
         U ovom testu dohvaća se lista računa i radnih naloga za pojedinog klijenta. U ovom slučaju
        za klijenta Bent. Test provjerava je li dobro dohvaća radne naloge i račune za klijenta.
         * */
        public void UcitajRadneNalogeUcitajRacune_DohvacanjeRacuneIRacnihNalogaZaKlijenta_DohvaceniRadniNaloziIRacuni()
        {
            RadniNalogService servisNalozi = new RadniNalogService();
            RacunService servisRacuni = new RacunService();
            KlijentServices servisKlijent = new KlijentServices();

            var klijenti = servisKlijent.DohvatiKlijente();
            Klijent postojeci = klijenti.FirstOrDefault(k => k.Naziv == "Bent");

            var radniNalozi = servisNalozi.DohvatiRadneNalogeZaKlijenta(postojeci);
            var racuni = servisRacuni.DohvatiRacuneZaKlijenta(postojeci);
            Assert.IsTrue(radniNalozi.Count == 2 && racuni.Count == 6);
        }

        [TestMethod]

        /*
         Kod ovog testa u objekt k.Naziv se može staviti naziv klijenta koji postoji u bazi. Kada
         
         */
        public void IzbrisiKlijenta_BrisanjeKlijentaIzBaze_IzbrisanKlijentIzBaze()
        {
            KlijentServices servisKlijenta = new KlijentServices();
            var klijenti = servisKlijenta.DohvatiKlijente();
            var brisi = klijenti.FirstOrDefault(k => k.Naziv == "Preis");
            bool uspjesno = servisKlijenta.Remove(brisi);
            Assert.IsTrue(uspjesno == true);
        }

        [TestMethod]
        [ExpectedException(typeof(BrisanjeKlijentaException))]
        public void IzbrisiKlijenta_BrisanjeKlijentaKojiImaRadneNaloge_BacanjeIznimke()
        {
            KlijentServices servisKlijenta = new KlijentServices();
            var klijenti = servisKlijenta.DohvatiKlijente();
            var brisi = klijenti.FirstOrDefault(k => k.Naziv == "Bent");
            servisKlijenta.Remove(brisi);
        }

        [TestMethod]
        [ExpectedException(typeof(OIBException))]
        public void PostojeciOIB_DodavanjeKlijentaSPostojecimOIBom()
        {
            KlijentServices servisKlijenta = new KlijentServices();

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
        public void DohvatiDesetNajboljih_DohvacanjeDesetNajvecihKlijenata_DohvacenoDesetNajvecihKlijenata()
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

            materijal.Add(new Materijal { Materijal_ID = 23, Naziv = "Željezo", CijenaMaterijala = 146, JedinicaMjere = "kg", Kolicina = 2, Opis = "", OpasnoPoZivot = false, QR_kod = "0Q69O3V24CQ6IE1PWXO3" });
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


        [TestMethod]
        public void RacunanjeUkupnog_IzdavanjeNovogRacuna_IspravnoRacunanjeIznosaStavki()
        {
            RacunanjeAPI racunanje = new RacunanjeAPI();
            List<StavkaRacun> lista = new List<StavkaRacun>();
            StavkaRacun stavka = new StavkaRacun()
            {
                UkupnaCijenaStavke = 300
            };
            lista.Add(stavka);
            StavkaRacun stavka2 = new StavkaRacun()
            {
                UkupnaCijenaStavke = 300
            };
            lista.Add(stavka2);

            double ukupno = racunanje.RacunanjeUkupnog(lista);

            Assert.IsTrue(ukupno == 600);
        }


    }
}
