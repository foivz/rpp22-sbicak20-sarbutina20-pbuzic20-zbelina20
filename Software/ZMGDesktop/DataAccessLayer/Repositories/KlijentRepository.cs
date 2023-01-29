using DataAccessLayer.Iznimke;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class KlijentRepository : Repository<Klijent>
    {
        public KlijentRepository() : base(new ZMGBaza())
        {

        }

        public override IQueryable<Klijent> GetAll()
        {
            var query = from s in Entities
                        select s;
            return query;
        }

        public IQueryable<Klijent> DohvatiDesetNajboljih()
        {
            var query = Entities.Where(x => x.Racun.Count() > 0)
                     .OrderByDescending(x => x.Racun.Count())
                     .Take(10);
            return query;
        }

        public override int Add(Klijent entity, bool saveChanges = true)
        {
            vecPostoji(entity);

            var klijent = new Klijent
            {
                Naziv = entity.Naziv,
                Adresa = entity.Adresa,
                Mjesto = entity.Mjesto,
                OIB = entity.OIB,
                BrojTelefona = entity.BrojTelefona,
                IBAN = entity.IBAN,
                Email = entity.Email,
                ukupniBrojRacuna = 0,
            };
            Entities.Add(klijent);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        private void vecPostoji(Klijent entity)
        {
            var naziv = Entities.SingleOrDefault(n => n.Naziv == entity.Naziv);
            var oib = Entities.SingleOrDefault(o => o.OIB == entity.OIB);
            var IBAN = Entities.SingleOrDefault(r => r.IBAN == entity.IBAN);
            var email = Entities.SingleOrDefault(e => e.Email == entity.Email);
            var telefon = Entities.SingleOrDefault(t => t.BrojTelefona == entity.BrojTelefona);
            if(naziv != null)
            {
                throw new UserException("Postoji već klijent s ovim nazivom: " + naziv);
            }
            if(oib != null)
            {
                throw new OIBException("Postoji već klijent s ovim OIB-om: " + naziv);
            }
            if(IBAN != null)
            {
                throw new IBANException("Ovaj IBAN već postoji: " + naziv);
            }
            if(email != null)
            {
                throw new EmailException("Ovaj email je već u upotrebi: " + naziv);
            }
            if(telefon != null)
            {
                throw new TelefonException("Ovaj broj telefona se već koristi: " + naziv);
            }
        }

        public override int Update(Klijent entity, bool saveChanges = true)
        {

            var klijent = Entities.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            vecPostojiAzuriraj(entity, klijent);

            klijent.Naziv = entity.Naziv;
            klijent.Adresa = entity.Adresa;
            klijent.BrojTelefona = entity.BrojTelefona;
            klijent.Mjesto = entity.Mjesto;
            klijent.OIB = entity.OIB;
            klijent.Email = entity.Email;
            klijent.IBAN = entity.IBAN;
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        private void vecPostojiAzuriraj(Klijent entity, Klijent klijent)
        {
            
                var naziv = Entities.SingleOrDefault(n => n.Naziv == entity.Naziv);
                var oib = Entities.SingleOrDefault(o => o.OIB == entity.OIB);
                var IBAN = Entities.SingleOrDefault(r => r.IBAN == entity.IBAN);
                var email = Entities.SingleOrDefault(e => e.Email == entity.Email);
                var telefon = Entities.SingleOrDefault(t => t.BrojTelefona == entity.BrojTelefona);
                if (naziv != null && naziv != klijent)
                {
                    throw new UserException("Postoji već klijent s ovim nazivom: " + naziv);
                }
                if (oib != null && oib != klijent)
                {
                    throw new OIBException("Postoji već klijent s ovim OIB-om: " + naziv);
                }
                if (IBAN != null && IBAN != klijent)
                {
                    throw new IBANException("Ovaj IBAN već postoji: " + naziv);
                }
                if (email != null && email != klijent)
                {
                    throw new EmailException("Ovaj email je već u upotrebi: " + naziv);
                }
                if (telefon != null && telefon != klijent)
                {
                    throw new TelefonException("Ovaj broj telefona se već koristi: " + naziv);
                }
        }

        public override int Remove(Klijent entity, bool saveChanges = true)
        {
            Entities.Attach(entity);
            if (provjeri(entity) == true)
            {
                Entities.Remove(entity);
                if (saveChanges)
                {
                    return SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new BrisanjeKlijentaException("Zabranjeno brisanje klijenta. Klijent ima radne naloge, račune i robu");
            }
        }

        private bool provjeri(Klijent entity)
        {
            if(entity.Racun.Count == 0 && entity.RadniNalog.Count == 0 && entity.Roba.Count == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
