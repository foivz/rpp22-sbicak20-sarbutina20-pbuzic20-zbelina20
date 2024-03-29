﻿using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class KlijentServices
    {

        public List<Klijent> DohvatiKlijente()
        {
            using (var repo = new KlijentRepository())
            {
                List<Klijent> klijenti = repo.GetAll().ToList();
                return klijenti;
            }
        }

        public List<Klijent> DohvatiDesetNajboljih()
        {
            using (var repo = new KlijentRepository())
            {
                List<Klijent> desetNajboljih = repo.DohvatiDesetNajboljih().ToList();
                return desetNajboljih;
            }
        }

        public bool Add(Klijent klijent)
        {
            bool uspjesno = false;

            using (var repo = new KlijentRepository())
            {
                int red = repo.Add(klijent);
                uspjesno = red > 0;
            }
                return uspjesno;
        }

        public bool Update(Klijent klijent)
        {
            bool uspjesno = false;

            using(var repo = new KlijentRepository())
            {
                int red = repo.Update(klijent);
                uspjesno = red > 0;
            }

            return uspjesno;
        }

        public bool Remove(Klijent klijent)
        {
            bool uspjesno = false;
                using(var repo = new KlijentRepository())
                {
                    int red = repo.Remove(klijent);
                    uspjesno = red > 0;
                }
            return uspjesno;
        }
    }
}
