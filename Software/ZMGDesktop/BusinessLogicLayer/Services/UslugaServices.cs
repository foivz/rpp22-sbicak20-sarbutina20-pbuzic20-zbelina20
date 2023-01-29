using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BusinessLogicLayer.Services
{
    public class UslugaServices
    {
        public List<Usluga> DohvatiUsluge()
        {
            using (var repo = new UslugaRepository())
            {
                var usluge = repo.GetAll().Distinct().ToList();
                return usluge;
            }
        }
    }
}
