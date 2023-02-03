using DataAccessLayer.Iznimke;
using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class MaterijalRepository : Repository<Materijal>
    {
        public MaterijalRepository() : base(new ZMGBaza())
        {

        }

        public bool ProvjeriQR(string qrKod)
        {
            var postoji = Entities.SingleOrDefault(k => k.QR_kod == qrKod);
            if (postoji!=null) return true;
            else return false;
        }

        public Materijal Azuriraj(string qrKod, int kolicina)
        {
            var postoji = Entities.SingleOrDefault(k => k.QR_kod == qrKod);
            if (postoji != null)
            {
                postoji.Kolicina += kolicina;
                SaveChanges();
                return postoji;
            }
            else return null;
        }

        public override int Add(Materijal entity, bool saveChanges = true)
        {
            var primka = Context.Primka.SingleOrDefault(k => k.Primka_ID == entity.Primka_ID);
            var usluga = Context.Usluga.SingleOrDefault(k => k.Usluga_ID == entity.Usluga_ID);
            
            string provjereniOpis;
            if (entity.Opis == null)  provjereniOpis = " ";
            else provjereniOpis = entity.Opis.ToString();

                var postoji = Entities.SingleOrDefault(k => k.Naziv == entity.Naziv);

            if (postoji == null)
            {
                var materijal = new Materijal
                {
                    Naziv = entity.Naziv,
                    CijenaMaterijala = entity.CijenaMaterijala,
                    JedinicaMjere = entity.JedinicaMjere,
                    Opis = provjereniOpis,
                    OpasnoPoZivot = entity.OpasnoPoZivot,
                    Kolicina = entity.Kolicina,
                    QR_kod = entity.QR_kod,
                    Usluga = usluga,
                    Primka = primka
                };
                Entities.Add(materijal);
                if (saveChanges)
                {
                    return SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
            else {
                throw new Exception("Materijal već postoji");
            }

        }

        public override int Remove(Materijal entity, bool saveChanges = true)
        {
            Entities.Attach(entity);
            if (entity.RadniNalog.Count == 0 && entity.Primka == null && entity.Usluga == null)
            {
                Entities.Remove(entity);
                if (saveChanges)
                {
                    return SaveChanges();
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                throw new BrisanjeMaterijalaException("Zabranjeno brisanje materijala koji se nalazi u radnom nalogu ili primci.");
            }
        }



        public override int Update(Materijal entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
