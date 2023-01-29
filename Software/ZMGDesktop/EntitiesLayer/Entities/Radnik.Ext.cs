using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntitiesLayer.Entities
{
    public partial class Radnik
    {
        public override string ToString()
        {
            return Ime + " " + Prezime;
        }
    }
}
