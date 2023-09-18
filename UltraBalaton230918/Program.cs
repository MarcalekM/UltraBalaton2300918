using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace UltraBalaton230918
{
    class Program
    {
        static void Main(string[] args)
        {
            var sportolok = new List<Sportolo> { };
            var sr = new StreamReader(
                path: @"..\..\..\src\ub2017egyeni.txt",
                Encoding.UTF8);
            while (!sr.EndOfStream) sportolok.Add(new Sportolo(sr.ReadLine()));

            Console.WriteLine($"3. feladat: A versenyen {sportolok.Count()} egyéni versenyző indult");

            var nt = sportolok
                .Where(nt => !nt.Kategoria && nt.Tav == 100);
            Console.WriteLine($"4. feladat: {nt.Count()} nő teljesítette a teljes távot");

            Console.Write("Adja meg a sportolo nevét:  ");
            string sn = Console.ReadLine();
            foreach (var s in sportolok)
            {
                if 
                {

                }
            }
        }
    }
}