using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class StavkaRepository : Repository<StavkaRacun>
    {
        public StavkaRepository() : base(new ZMGBaza())
        {

        }

        public StavkaRacun InitStavka(StavkaRacun entity, Roba _roba, Usluga _usluga)
        {
            var roba = Context.Roba.SingleOrDefault(r => r.Roba_ID == _roba.Roba_ID);
            var usluga = Context.Usluga.SingleOrDefault(r => r.Usluga_ID == _usluga.Usluga_ID);

            Context.Roba.Attach(roba);
            Context.Usluga.Attach(usluga);

            StavkaRacun novaStavka = new StavkaRacun()
            {
                Roba = roba,
                Usluga = usluga,
                Roba_ID = roba.Roba_ID,
                Usluga_ID = usluga.Usluga_ID,

                KolikoRobePoJedinici = entity.KolikoRobePoJedinici,
                KolicinaRobe = entity.KolicinaRobe,
                DatumIzrade = entity.DatumIzrade,
                JedinicaMjere = entity.JedinicaMjere,
                JedinicnaCijena = entity.JedinicnaCijena,
                UkupnaCijenaStavke = entity.UkupnaCijenaStavke
            };

            return novaStavka;
        }
        
        public IQueryable<StavkaRacun> DohvatiStavkeZaRacun(int id)
        {
            var query = from s in Entities.Include("Roba").Include("Usluga") where s.Racun.Racun_ID == id select s;
            return query;
        }

        public override int Update(StavkaRacun entity, bool saveChanges = true)
        {
            throw new NotImplementedException();
        }
    }
}
