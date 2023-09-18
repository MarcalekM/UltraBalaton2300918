using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltraBalaton230918
{
    class Sportolo
    {
        public string Nev { get; set; }
        public int Rajtszam { get; set; }
        public bool Kategoria { get; set; }
        public DateTime Ido { get; set; }
        public int Tav { get; set; }

        public Sportolo(string r)
        {
            var v = r.Split(';');
            Nev = v[0];
            Rajtszam = int.Parse(v[1]);
            Kategoria = v[2] == "Ferfi";
            Ido = DateTime.ParseExact(v[3], "hh:mm:ss tt", System.Globalization.CultureInfo.CurrentCulture);
            Tav = int.Parse(v[4]);
        }
    }
}
