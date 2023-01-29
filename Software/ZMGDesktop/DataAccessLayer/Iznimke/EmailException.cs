using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class EmailException: ApplicationException
    {
        public string  Poruka { get; set; }
        public EmailException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
