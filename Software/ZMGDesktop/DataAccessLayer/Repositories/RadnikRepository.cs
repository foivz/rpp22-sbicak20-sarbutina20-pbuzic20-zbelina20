using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Security.Cryptography;
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
            using (var sha256 = SHA256.Create())
            {
                var enteredBytes = Encoding.UTF8.GetBytes(entity.Lozinka);
                var enteredHashedPassword = BitConverter.ToString(sha256.ComputeHash(enteredBytes)).Replace("-", "").ToLower();
                entity.Lozinka = enteredHashedPassword;

                var query = await (from s in Entities
                                   where (entity.Korime == s.Korime && entity.Lozinka == s.Lozinka)
                                   select s).FirstOrDefaultAsync();
                return query;
            }

                
        }

        public override int Update(Radnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

    }
}
