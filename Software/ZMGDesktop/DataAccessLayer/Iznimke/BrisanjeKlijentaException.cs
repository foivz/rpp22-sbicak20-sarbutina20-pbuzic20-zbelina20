using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class BrisanjeKlijentaException: ApplicationException
    {
        public string Poruka { get; set; }

        public BrisanjeKlijentaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
