using EntitiesLayer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace BusinessLogicLayer.LogikaZaRacune
{
    public class RacunanjeAPI
    {
        public double RacunanjeUkupnog(List<StavkaRacun> stavke)
        {
            double ukupno = 0;

            foreach(var st in stavke)
            {
                ukupno += st.UkupnaCijenaStavke;
            }

            return ukupno;
        }

        public double RacunanjePDV(double ukupno)
        {
            ukupno = ukupno * 0.25;
            return ukupno;
        }

        public double RacunanjeUkupnogPDV(double iznosStavki, double ukupnoPDV)
        {
            return iznosStavki + ukupnoPDV;
        }
    }
}
