using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RacunService
    {

        public List<Racun> DohvatiRacuneZaKlijenta(Klijent klijent)
        {
            using(var repo = new RacunRepository())
            {
                List<Racun> racuni = repo.DohvatiRacuneZaKlijenta(klijent).ToList();
                return racuni;
            }
        }

        public List<Racun> DohvatiSveRacune()
        {
            using (var repo = new RacunRepository())
            {
                List<Racun> racuni = repo.DohvatiSveRacune().ToList();
                return racuni;
            }
        }

        public void DodajRacun(Racun racun)
        {
            using (var repo = new RacunRepository()) {
                repo.Add(racun);
            }
        }
    }
}
