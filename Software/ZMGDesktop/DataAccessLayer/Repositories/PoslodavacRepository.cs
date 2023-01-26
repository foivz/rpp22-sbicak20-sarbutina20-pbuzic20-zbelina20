using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class PoslodavacRepository : Repository<Poslodavac>
    {
        public PoslodavacRepository() : base(new ZMGBaza())
        {

        }

        public override int Update(Poslodavac entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Poslodavac> DohvatiPoslodavca(int id)
        {
           var query = from p in Entities.Include("Racun") where id == 1 select p;
           return query;
        }
    }
}
