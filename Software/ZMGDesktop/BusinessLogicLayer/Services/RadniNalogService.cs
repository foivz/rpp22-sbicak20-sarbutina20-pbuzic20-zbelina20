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

        public List<RadniNalog> DohvatiRadneNaloge()
        {
            using(var repo = new RadniNalogRepository())
            {
                List<RadniNalog> radniNalozi = repo.DohvatiSveRadneNaloge().ToList();
                return radniNalozi;
            }
        }

        public List<RadniNalog> DohvatiRadneNalogePoStatusima()
        {
            using (var repo = new RadniNalogRepository())
            {
                List<RadniNalog> radniNalozi = repo.DohvatiRadneNalogePoStatusima().ToList();
                return radniNalozi;
            }
        }

        public bool DodajRadniNalog(RadniNalog radniNalog)
        {
            bool uspjesno = false;

            using (var repo = new RadniNalogRepository())
            {
                int red = repo.Add(radniNalog);
                uspjesno = red > 0;
            }

            return uspjesno;
        }

        public bool ObrisiRadniNalog(RadniNalog radniNalog)
        {
            bool uspjesno = false;

            using (var repo = new RadniNalogRepository())
            {
                int red = repo.Remove(radniNalog);
                uspjesno = red > 0;
            }

            return uspjesno;
        }

        public void AzurirajRadniNalog(RadniNalog radniNalog)
        {
            using (var repo = new RadniNalogRepository())
            {
                repo.Update(radniNalog);
            }
        }
    }
}
