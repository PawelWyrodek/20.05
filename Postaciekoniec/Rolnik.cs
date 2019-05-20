using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Postaciekoniec
{
    public class Rolnik : Postac
    {
        public Rolnik(string imie, string hp) : base(imie, hp)
        {

        }
        public string Uprawiaj()
        {
            return "Uprawiam";
        }

        public string Zbieraj()
        {
            return "Zbieram";
        }
    }
}
