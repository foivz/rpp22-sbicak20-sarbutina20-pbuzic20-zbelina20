using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UslugaRepository : Repository<Usluga>
    {
        public UslugaRepository() : base(new ZMGBaza())
        {

        }
        public override int Update(Usluga entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public override IQueryable<Usluga> GetAll()
        {
            var query = from p in Entities.Include("Materijal").Include("StavkaRacun")
                        select p; 
            return query;
        }
    }
}
