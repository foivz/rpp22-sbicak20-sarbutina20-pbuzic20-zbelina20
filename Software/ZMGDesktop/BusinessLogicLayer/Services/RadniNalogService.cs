using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RadniNalogService
    {

        public List<RadniNalog> DohvatiRadneNalogeZaKlijenta(Klijent klijent)
        {
            using(var repo = new RadniNalogRepository())
            {
                List<RadniNalog> radniNalozi = repo.DohvatiRadneNalogeZaKlijenta(klijent).ToList();
                return radniNalozi;
            }
        }
    }
}
