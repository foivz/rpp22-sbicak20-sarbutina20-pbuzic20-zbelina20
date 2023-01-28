﻿using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class StavkaRacunService
    {
        public List<StavkaRacun> DohvatiStavkeRacuna(int id)
        {
            using (var repo = new StavkaRepository())
            {
                List<StavkaRacun> lista = repo.DohvatiStavkeZaRacun(id).ToList();
                return lista;
            }
        }

        public StavkaRacun InitStavka(StavkaRacun _stavka, Roba roba, Usluga usluga)
        {
            using (var repo = new StavkaRepository())
            {
                StavkaRacun stavka = repo.InitStavka(_stavka, roba, usluga);
                return stavka;
            }
        }
    }
}
