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
        public async Task<Radnik> ProvjeriRadnikaAsync(Radnik prosljRadnik)
        {
            using (var repo = new RadnikRepository())
            {
                var radnik = await repo.DohvatiRadnikaAsync(prosljRadnik);
                return radnik;
            }
        }
    }
}
