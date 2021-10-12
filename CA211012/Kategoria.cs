using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA211012
{
    class Kategoria
    {
        public string Nev { get; set; }
        public int Tulelo { get; set; }
        public int Eltunt { get; set; }

        public Kategoria(string r)
        {
            var t = r.Split(';');

            Nev = t[0];
            Tulelo = int.Parse(t[1]);
            Eltunt = int.Parse(t[2]);
        }
    }
}
