using DataAccessLayer;
using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class PoslodavacServices
    {
        public Poslodavac GetPoslodavac()
        {
            int id = 1;
            List<Poslodavac> lista = new List<Poslodavac>();
            Poslodavac poslodavac = new Poslodavac();

            using (var repo = new PoslodavacRepository())
            {
                lista = repo.DohvatiPoslodavca(id).ToList();
            }
            poslodavac = lista.FirstOrDefault(p => p.Poslodavac_ID == id);
            return poslodavac;
        }
    }
}
