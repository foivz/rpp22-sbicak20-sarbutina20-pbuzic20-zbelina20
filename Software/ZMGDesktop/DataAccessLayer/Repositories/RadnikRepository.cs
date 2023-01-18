using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class RadnikRepository : Repository<Radnik>
    {
        public RadnikRepository() : base(new Northwind())
        {

        }


        public override int Update(Radnik entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

    }
}
