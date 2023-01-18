using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class RadnikRepository : Repository<Radnik>
    {
        public RadnikRepository() : base(new Northwind())
        {

        }

        public Radnik DohvatiRadnika(Radnik entity)
        {
            var query = (from s in Entities
                        where (entity.Korime == s.Korime && entity.Lozinka == s.Lozinka) 
                        select s).FirstOrDefault();
            return query;
        }

        public override int Update(Radnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

    }
}
