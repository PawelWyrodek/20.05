using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postaciekoniec
{
    public class Wojownik : Postac
    {
        public Wojownik(string imie, string hp) : base(imie, hp)
        {

        }
        public string Walcz()
        {
            return "Walczę";
        }

        public string Patroluj()
        {
            return "Patroluję";
        }

        public string Pilnuj()
        {
            return "Pilnuje";
        }
    }
}
