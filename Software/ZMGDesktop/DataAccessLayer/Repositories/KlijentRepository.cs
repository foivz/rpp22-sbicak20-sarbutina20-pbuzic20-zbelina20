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
        public KlijentRepository() : base(new Northwind())
        {

        }

        public override IQueryable<Klijent> GetAll()
        {
            var query = from s in Entities.Include("IzvjestajKlijenata")
                        select s;
            return query;
        }

        public IQueryable<Klijent> DohvatiDesetNajboljih()
        {
            var query = Entities.OrderByDescending(x => x.Racun.Count()).Take(5);
            return query;
        }

        public override int Add(Klijent entity, bool saveChanges = true)
        {
            var izvjestaj = Context.IzvjestajKlijenata.SingleOrDefault(k => k.IzvjestajKlijenata_ID == entity.IzvjestajKlijenata_ID);

            var postoji = Entities.SingleOrDefault(k => k.Naziv == entity.Naziv);

            if(postoji == null) { 
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
                IzvjestajKlijenata = izvjestaj
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
            else
            {
                throw new UserException("Ne mozete ubaciti postojeceg korisnika");
            }

        }

        public override int Update(Klijent entity, bool saveChanges = true)
        {

            var izvjestajKlijenata = Context.IzvjestajKlijenata.SingleOrDefault(k => k.IzvjestajKlijenata_ID == entity.IzvjestajKlijenata_ID);
            var klijent = Entities.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);

            klijent.Naziv = entity.Naziv;
            klijent.Adresa = entity.Adresa;
            klijent.BrojTelefona = entity.BrojTelefona;
            klijent.Mjesto = entity.Mjesto;
            klijent.OIB = entity.OIB;
            klijent.Email = entity.Email;
            klijent.IBAN = entity.IBAN;
            //klijent.IzvjestajKlijenata_ID = izvjestajKlijenata.IzvjestajKlijenata_ID;
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
