using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class RobaService
    {
        public List<Roba> DohvatiRobuKlijenta(int klijentID)
        {
            using (var repo = new RobaRepository())
            {
                List<Roba> roba = repo.DohvatiRobuKlijenta(klijentID).ToList();
                return roba;
            }
        }


        // metode za rjesenje dupliciranja
        public List<string> DohvatiRobuKlijentaDistinct(int id)
        {
            using (var repo = new RobaRepository())
            {
                var robe = repo.DohvatiRobuKlijentaDistinct(id).Distinct().ToList();
                return robe;
            }
        }

        public Roba DohvatiRobuPoNazivu(string selectedValue)
        {
            using (var repo = new RobaRepository())
            {
                var roba = repo.DohvatiRobuPoNazivu(selectedValue);
                var vracenaRoba = roba.FirstOrDefault(u => u.Naziv == selectedValue);
                return vracenaRoba;
            }
        }
        //

        public bool Add(Roba roba)
        {
            bool uspjesno = false;

            using (var repo = new RobaRepository())
            {
                int red = repo.Add(roba);
                uspjesno = red > 0;
            }
            return uspjesno;
        }

        public bool Update(Roba roba)
        {
            bool uspjesno = false;

            using (var repo = new RobaRepository())
            {
                int red = repo.Update(roba);
                uspjesno = red > 0;
            }

            return uspjesno;
        }
    }
}
