using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RacunRepository: Repository<Racun>
    {

        public RacunRepository(): base(new ZMGBaza())
        {

        }

        public override int Add(Racun entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            var poslodavac = Context.Poslodavac.SingleOrDefault(p => p.Poslodavac_ID == entity.Poslodavac_ID);
            var radnik = Context.Radnik.SingleOrDefault(r => r.Radnik_ID == entity.Radnik_ID);

            bool[] provjera = new bool[2];
            provjera[0] = false;
            provjera[1] = false;

            Usluga cincanje = null;
            Usluga niklanje = null;

            // provjera za attachanje za bazu podataka kako se ne bi duplicirla usluga i roba
            foreach (var stavka in entity.StavkaRacun)
            {
                if (provjera[0] == false && stavka.Usluga.Naziv == "Cincanje")
                {
                    provjera[0] = true;
                    cincanje = Context.Usluga.Attach(stavka.Usluga);
                }

                if (provjera[1] == false && stavka.Usluga.Naziv == "Niklanje")
                {
                    provjera[1] = true;
                    niklanje = Context.Usluga.Attach(stavka.Usluga);
                }

                if (stavka.Usluga.Naziv == "Cincanje")
                {
                    stavka.Usluga = cincanje;
                }

                if (stavka.Usluga.Naziv == "Niklanje")
                {
                    stavka.Usluga = niklanje;
                }

                Context.Roba.Attach(stavka.Roba);
            }

            var racun = new Racun
            {
                Klijent = klijent,
                Poslodavac = poslodavac,
                Radnik = radnik,
                Fakturirao = entity.Fakturirao,
                Opis = entity.Opis,
                NacinPlacanja = entity.NacinPlacanja,
                UkupnaCijena = entity.UkupnaCijena,
                PDV= entity.PDV,
                UkupnoStavke= entity.UkupnoStavke,
                DatumIzdavanja= entity.DatumIzdavanja,
                StavkaRacun= entity.StavkaRacun,
                RokPlacanja= entity.RokPlacanja
            };

            Entities.Add(racun);
            klijent.ukupniBrojRacuna = klijent.Racun.Count();
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public IQueryable<Racun> DohvatiRacuneZaKlijenta(Klijent entity)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);

            var query = from s in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik").Include("StavkaRacun")
                        where s.Klijent_ID == entity.Klijent_ID
                        select s;
            return query;
        }

        public IQueryable<Racun> DohvatiSveRacune()
        {
            var query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik") where r.Poslodavac_ID == 1 select r;
            return query;
        }

        public IQueryable<Racun> DohvatiOdredeniRacun(int id)
        {
            var query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik") where r.Racun_ID == id select r;
            return query;
        }

        //pretrazivanje
        public IQueryable<Racun> DohvatiPremaPretrazivanju(Klijent entity, int Radnik_ID, int pretrazivanje = 0, int _sortiranje = 0)
        {
            IQueryable<Racun> query = null;
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            // parametar pretrazivanje oznacava koji je radiobutton u toj grupi

            switch (pretrazivanje)
            {
                case 0:
                    if (_sortiranje == 1)
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID)
                                orderby r.Racun_ID descending
                                select r;
                    }
                    else {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID)
                                orderby r.Racun_ID ascending
                                select r;
                    }
                    break;
                // datum
                case 1:
                    if (_sortiranje == 1)
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID)
                                orderby r.DatumIzdavanja descending
                                select r;
                    }
                    else
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID)
                                orderby r.DatumIzdavanja ascending
                                select r;
                    }
                    break;
                // ukupno
                case 2:
                    if (_sortiranje == 1)
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID)
                                orderby r.UkupnaCijena descending
                                select r;
                    }
                    else
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID)
                                orderby r.UkupnaCijena ascending
                                select r;
                    }
                    break;
                // prema racunima radnika
                case 3:
                    if (_sortiranje == 1)
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID && r.Radnik_ID == Radnik_ID)
                                orderby r.Radnik_ID descending
                                select r;
                    }
                    else
                    {
                        query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik")
                                where (r.Klijent_ID == entity.Klijent_ID && r.Radnik_ID == Radnik_ID)
                                orderby r.Radnik_ID ascending
                                select r;
                    }
                    break;
            }

            return query;
        }

        public override int Update(Racun entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
