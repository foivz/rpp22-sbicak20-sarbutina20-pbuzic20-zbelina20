using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RadniNalogRepository : Repository<RadniNalog>
    {
        public RadniNalogRepository() : base(new ZMGBaza())
        {

        }

        public IQueryable<RadniNalog> DohvatiRadneNalogeZaKlijenta(Klijent entity)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            
                var query = from s in Entities.Include("Klijent").Include("Radnik")
                            where s.Klijent_ID == klijent.Klijent_ID
                            select s;
                return query; 
        }

        public IQueryable<RadniNalog> DohvatiSveRadneNaloge()
        {
            var query = from r in Entities.Include("Klijent").Include("Radnik").Include("Materijal").Include("Roba")
                        select r;
            return query;
        }

        public IQueryable<RadniNalog> DohvatiRadneNalogePoStatusima()
        {
            var query = from r in Entities.Include("Klijent").Include("Radnik").Include("Materijal").Include("Roba")
                        orderby r.Status
                        select r;
            return query;
        }

        public override int Update(RadniNalog entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            var radnik = Context.Radnik.SingleOrDefault(r => r.Radnik_ID == entity.Radnik_ID);
            var radniNalog = Entities.SingleOrDefault(r => r.RadniNalog_ID == entity.RadniNalog_ID);

            foreach (var materijal in entity.Materijal)
            {
                Context.Materijal.Attach(materijal);
            }

            radniNalog.Radnik = radnik;
            radniNalog.Klijent = klijent;
            radniNalog.Kolicina = entity.Kolicina;
            radniNalog.QR_kod = entity.QR_kod;
            radniNalog.Opis = entity.Opis;
            radniNalog.DatumStvaranja = entity.DatumStvaranja;
            radniNalog.Status= entity.Status;
            radniNalog.Materijal = entity.Materijal;
            radniNalog.Roba = entity.Roba;

            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Add(RadniNalog entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            var radnik = Context.Radnik.SingleOrDefault(r => r.Radnik_ID == entity.Radnik_ID);

            foreach (var materijal in entity.Materijal)
            {
                Context.Materijal.Attach(materijal);
            }
            
            foreach (var roba in entity.Roba)
            {
                Context.Roba.Attach(roba);
            } 

            var nalog = new RadniNalog
            {
                Kolicina = entity.Kolicina,
                Radnik = radnik,
                Klijent = klijent,
                QR_kod = entity.QR_kod,
                Opis = entity.Opis,
                DatumStvaranja= entity.DatumStvaranja,
                Status = entity.Status,
                Materijal = entity.Materijal,
                Roba = entity.Roba,
                Klijent_ID = klijent.Klijent_ID,
                Radnik_ID = radnik.Radnik_ID
            };
            Entities.Add(nalog);
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
