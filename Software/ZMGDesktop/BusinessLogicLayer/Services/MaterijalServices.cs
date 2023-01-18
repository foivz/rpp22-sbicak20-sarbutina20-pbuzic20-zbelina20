using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MaterijalServices
    {
        public List<Materijal> DohvatiMaterijale()
        {
            using (var repo = new MaterijalRepository())
            {
                var materijali = repo.GetAll().ToList();
                return materijali;
            }
        }
    }
}
