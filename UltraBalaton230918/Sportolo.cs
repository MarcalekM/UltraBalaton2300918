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
        public string Rajtszam { get; set; }
        public bool Kategoria { get; set; }
        public TimeSpan Versenyido { get; set; }
        public int TavSzazalek { get; set; }

        public Sportolo(string r)
        {
            var v = r.Split(';');
            Nev = v[0];
            Rajtszam = v[1];
            Kategoria = v[2] == "Ferfi";
            var ido = v[3].Split(';');
            Versenyido = new TimeSpan(
                hours: int.Parse(ido[0]),
                minutes: int.Parse(ido[1]),
                seconds: int.Parse(ido[2]));
            TavSzazalek = int.Parse(v[4]);
        }
    }
}
