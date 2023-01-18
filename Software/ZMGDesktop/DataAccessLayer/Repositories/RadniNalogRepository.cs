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
        public RadniNalogRepository() : base(new Northwind())
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

        public override int Update(RadniNalog entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(k => k.Klijent_ID == entity.Klijent_ID);
            var radnik = Context.Radnik.SingleOrDefault(r => r.Radnik_ID == entity.Radnik_ID);

            var radniNalog = Entities.SingleOrDefault(r => r.RadniNalog_ID == entity.RadniNalog_ID);
            radniNalog.Radnik = radnik;
            radniNalog.Klijent = klijent;
            radniNalog.Kolicina = entity.Kolicina;
            radniNalog.QR_kod = entity.QR_kod;
            radniNalog.Opis = entity.Opis;
            radniNalog.DatumStvaranja = entity.DatumStvaranja;
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
