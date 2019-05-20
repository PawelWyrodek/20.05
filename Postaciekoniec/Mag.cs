using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postaciekoniec
{
    class Mag : Postac
    {
        public Mag(string imie, string hp) : base(imie, hp)
        {

        }
        public string Walcz()
        {
            return "Walczę";
        }

        public string Pilnuj()
        {
            return "Pilnuję";
        }

    }
}
