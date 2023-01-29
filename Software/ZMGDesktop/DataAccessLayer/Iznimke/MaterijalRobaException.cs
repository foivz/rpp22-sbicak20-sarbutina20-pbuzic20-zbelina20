using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class MaterijalRobaException : ApplicationException
    {
        public string Poruka { get; set; }

        public MaterijalRobaException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
