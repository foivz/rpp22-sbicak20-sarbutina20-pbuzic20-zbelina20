using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PrimkaRepository : Repository<Primka>
    {
        public PrimkaRepository() : base(new ZMGBaza())
        {

        }

        public override int Add(Primka entity, bool saveChanges = true)
        {
            var postoji = Entities.SingleOrDefault(k => k.Primka_ID == entity.Primka_ID);
            if(postoji == null)
            {
                var primka = new Primka
                {
                    Naziv_Materijal = entity.Naziv_Materijal,
                    Kolicina = entity.Kolicina,
                    Datum = entity.Datum
                };
                Entities.Add(primka);
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
                throw new Exception("Primka već postoji");
            }

        }

        public override int Update(Primka entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }


    }
}
