using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RadnikServices
    {
        public Radnik ProvjeriRadnika(Radnik prosljRadnik)
        {
            using (var repo = new RadnikRepository())
            {
                var radnik = repo.DohvatiRadnika(prosljRadnik);
                return radnik;
            }
        }
    }
}
