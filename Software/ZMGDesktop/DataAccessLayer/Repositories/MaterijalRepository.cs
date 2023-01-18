using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    internal class MaterijalRepository : Repository<Materijal>
    {
        public MaterijalRepository() : base(new Northwind())
        {

        }

        public override IQueryable<Materijal> GetAll()
        {
            var query = from s in Entities.Include("Primka").Include("Usluga")
                        select s;
            return query;
        }

        public override int Add(Materijal entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }

        public override int Update(Materijal entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }




    }
}
