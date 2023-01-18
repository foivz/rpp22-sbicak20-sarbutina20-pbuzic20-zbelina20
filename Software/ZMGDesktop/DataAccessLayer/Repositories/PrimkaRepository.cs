using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class PrimkaRepository : Repository<Primka>
    {
        public PrimkaRepository() : base(new Northwind())
        {

        }

        public override int Update(Primka entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }


    }
}
