using DataAccessLayer.Repositories;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Services
{
    public class MaterijalServices
    {
        public List<Materijal> DohvatiMaterijale()
        {
            using (var repo = new MaterijalRepository())
            {
                var materijali = repo.GetAll().ToList();
                return materijali;
            }
        }

        public bool ProvjeriQR(string qrKod)
        {
            using(var repo = new MaterijalRepository())
            {
                var postoji = repo.ProvjeriQR(qrKod);
                if (postoji) return true;
                else return false;
            }
            
        }
        public Materijal AzurirajMaterijal(string qrKod, int kolicina)
        {
            Materijal materijal;

            using (var repo = new MaterijalRepository())
            {
                materijal = repo.Azuriraj(qrKod, kolicina);
            }

            return materijal;
        }

        public bool obrisiMaterijal(Materijal materijal)
        {
            bool uspjeh = false;

                using (var repo = new MaterijalRepository())
                {
                    int redovi = repo.Remove(materijal);
                    uspjeh = redovi > 0;
                }
            

            return uspjeh;
        }

        public bool dodajMaterijal(Materijal materijal)
        {
            bool uspjeh = false;
            using (var repo = new MaterijalRepository())
            {
                int affectedRows = repo.Add(materijal);
                uspjeh = affectedRows > 0;
            }
            return uspjeh;
        }


    }
}
