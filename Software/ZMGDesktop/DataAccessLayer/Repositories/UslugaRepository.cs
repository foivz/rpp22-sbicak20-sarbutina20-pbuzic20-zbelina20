using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class UslugaRepository : Repository<Usluga>
    {
        public UslugaRepository() : base(new Northwind())
        {

        }
        public override int Update(Usluga entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }




    }
}
