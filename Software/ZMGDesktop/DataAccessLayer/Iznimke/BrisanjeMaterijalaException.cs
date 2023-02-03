using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class BrisanjeMaterijalaException : ApplicationException
    {
        public string Poruka { get; set; }

        public BrisanjeMaterijalaException(string poruka)
        {
            Poruka = poruka;
        }

    }
}
