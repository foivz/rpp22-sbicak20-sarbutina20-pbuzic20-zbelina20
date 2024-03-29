﻿using DataAccessLayer.Repositories;
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
            using (var repo = new RacunRepository())
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
            using (var repo = new RacunRepository())
            {
                repo.Add(racun);
            }
        }

        public Racun DohvatiOdredeniRacun(int id)
        {
            List<Racun> listaRacuna = new List<Racun>();
            using (var repo = new RacunRepository())
            {
                listaRacuna = repo.DohvatiOdredeniRacun(id).ToList();
            }
            Racun racun;
            racun = listaRacuna[0];
            return racun;
        }

        public Racun DohvatiZadnjiRacun()
        {
            List<Racun> listaRacuna = new List<Racun>();
            using (var repo = new RacunRepository())
            {
                listaRacuna = repo.DohvatiSveRacune().ToList();
            }
            Racun racun;
            racun = listaRacuna.Last();
            return racun;
        }

        public List<Racun> DohvatiRacunePretrazivanje(Klijent klijent, int id, int pretrazivanje = 0, int sortiranje = 0)
        {
            using (var repo = new RacunRepository())
            {
                List<Racun> racuni = repo.DohvatiPremaPretrazivanju(klijent, id, pretrazivanje, sortiranje).ToList();
                return racuni;
            }
        }
    }
}
