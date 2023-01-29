using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RobaRepository : Repository<Roba>
    {
        public RobaRepository() : base(new ZMGBaza())
        {

        }

        public IQueryable<Roba> DohvatiRobuKlijenta(int klijentID)
        {
            var query = from r in Entities
                        where r.Klijent_ID == klijentID
                        select r;
            return query;
        }

        public override int Add(Roba entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(r => r.Klijent_ID == entity.Klijent_ID);

            Roba roba = new Roba
            {
                Naziv = entity.Naziv,
                Kolicina = entity.Kolicina,
                Klijent = klijent
            };
            
            Entities.Add(roba);
            if (saveChanges)
            {
                return SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public override int Update(Roba entity, bool saveChanges = true)
        {
            var klijent = Context.Klijent.SingleOrDefault(r => r.Klijent_ID == entity.Klijent_ID);
            var roba = Entities.SingleOrDefault(r => r.Roba_ID == entity.Roba_ID);

            roba.Naziv = entity.Naziv;
            roba.Kolicina = entity.Kolicina;
            roba.Klijent = klijent;

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
