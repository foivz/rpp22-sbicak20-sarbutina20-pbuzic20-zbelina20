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
        public MaterijalRepository() : base(new Northwind())
        {

        }


        public override int Add(Materijal entity, bool saveChanges = true)
        {
            //var primka = Context.Primka.SingleOrDefault(k => k.Primka_ID == entity.Primka_ID);
            var usluga = Context.Usluga.SingleOrDefault(k => k.Usluga_ID == entity.Usluga_ID);

            var postoji = Entities.SingleOrDefault(k => k.Naziv == entity.Naziv);

            if (postoji == null)
            {
                var materijal = new Materijal
                {
                    Materijal_ID = entity.Materijal_ID,
                    Naziv = entity.Naziv,
                    CijenaMaterijala = entity.CijenaMaterijala,
                    JedinicaMjere = entity.JedinicaMjere,
                    Opis = entity.Opis,
                    OpasnoPoZivot = entity.OpasnoPoZivot,
                    Kolicina = entity.Kolicina,
                    QR_kod = entity.QR_kod
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

        public override int Update(Materijal entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }


    }
}
