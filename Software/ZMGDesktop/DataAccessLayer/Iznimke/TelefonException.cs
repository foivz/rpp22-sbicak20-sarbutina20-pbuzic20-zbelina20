using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class TelefonException: ApplicationException
    {
        public string Poruka { get; set; }
        public TelefonException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
