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

            var racun = new Racun
            {
                Klijent = klijent,
                Poslodavac = poslodavac,
                Radnik = radnik,
                Fakturirao = entity.Fakturirao,
                Opis = entity.Opis,
                NacinPlacanja = entity.NacinPlacanja,
                UkupnaCijena = entity.UkupnaCijena,
                Radnik_ID = entity.Radnik_ID,
                Klijent_ID = entity.Klijent_ID,
                Poslodavac_ID = entity.Poslodavac_ID,
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
            var poslodavac = Context.Poslodavac.SingleOrDefault(p => p.Poslodavac_ID == 1);

            var query = from r in Entities.Include("Klijent").Include("Poslodavac").Include("Radnik") where poslodavac.Poslodavac_ID == 1 select r;
            return query;
        }

        public override int Update(Racun entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            var poslodavac = Context.Poslodavac.SingleOrDefault(p => p.Poslodavac_ID == entity.Poslodavac_ID);
            var radnik = Context.Radnik.SingleOrDefault(r => r.Radnik_ID == entity.Radnik_ID);

            var racun = Entities.SingleOrDefault(r => r.Racun_ID == entity.Racun_ID);
            racun.Klijent = klijent;
            racun.Poslodavac = poslodavac;
            racun.Radnik = radnik;
            racun.Fakturirao = entity.Fakturirao;
            racun.Opis = entity.Opis;
            racun.NacinPlacanja = entity.NacinPlacanja;
            racun.UkupnaCijena = entity.UkupnaCijena;
            racun.Radnik_ID = radnik.Radnik_ID;
            racun.Klijent_ID = klijent.Klijent_ID;
            racun.Poslodavac_ID = poslodavac.Poslodavac_ID;
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }
    }
}
