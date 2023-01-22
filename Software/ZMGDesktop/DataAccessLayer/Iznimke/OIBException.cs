using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class OIBException: ApplicationException
    {
        public string Poruka { get; set; }
        public OIBException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
