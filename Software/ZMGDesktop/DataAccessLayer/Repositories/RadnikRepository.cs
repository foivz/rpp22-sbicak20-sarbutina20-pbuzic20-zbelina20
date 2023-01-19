using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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

        public async Task<Radnik> DohvatiRadnikaAsync(Radnik entity)
        {
            var query = await (from s in Entities
                        where (entity.Korime == s.Korime && entity.Lozinka == s.Lozinka) 
                        select s).FirstOrDefaultAsync();
            return query;
        }

        public override int Update(Radnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

    }
}
