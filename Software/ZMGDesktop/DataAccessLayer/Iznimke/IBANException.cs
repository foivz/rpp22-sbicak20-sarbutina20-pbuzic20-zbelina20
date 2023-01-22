using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class IBANException : ApplicationException
    {
        public string Poruka { get; set; }
        public IBANException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
