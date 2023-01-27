using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StavkaRepository : Repository<StavkaRacun>
    {
        public StavkaRepository() : base(new ZMGBaza())
        {

        }
        
        public IQueryable<StavkaRacun> DohvatiStavkeZaRacun(int id)
        {
            var query = from s in Entities.Include("Roba").Include("Usluga") where s.Racun.Racun_ID == id select s;
            return query;
        }

        public override int Update(StavkaRacun entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
