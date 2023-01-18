using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Iznimke
{
    public class UserException : ApplicationException
    {

        public string Poruka { get; set; }

        public UserException(string poruka)
        {
            Poruka = poruka;
        }
    }
}
