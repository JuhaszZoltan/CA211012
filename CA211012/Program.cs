using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA211012
{
    class Program
    {
        static List<Kategoria> kategoriak = new List<Kategoria>();
        static void Main()
        {
            Beolvas();
            Console.WriteLine($"2. feladat: {kategoriak.Count} db");
            Console.WriteLine($"3. feladat: {kategoriak.Sum(x => x.Eltunt + x.Tulelo)} fő");
            Console.Write("4. feladat: Kulcsszó: ");
            string ksz = Console.ReadLine();
            bool van = kategoriak.Any(x => x.Nev.Contains(ksz));
            Console.WriteLine(
                $"\t{(van ? "Van találat" : "Nincs találat")}");
            if(van)
            {
                Console.WriteLine("5. feladat:");
                kategoriak.Where(x => x.Nev.Contains(ksz))
                    .ToList()
                    .ForEach(y => Console.WriteLine($"\t{y.Nev} {y.Tulelo + y.Eltunt} fő"));
            }
            Console.WriteLine("6. feladat:");
            kategoriak.Where(x => (x.Eltunt + x.Tulelo) * .6F < x.Eltunt)
                .ToList()
                .ForEach(z => Console.WriteLine($"\t{z.Nev}"));
            Console.WriteLine($"7. feladat: {kategoriak.Where(x => x.Tulelo == kategoriak.Max(y => y.Tulelo)).First().Nev}");
            Console.ReadKey();
        }

        private static void Beolvas()
        {
            using (var sr = new StreamReader(@"..\..\res\titanic.txt", Encoding.UTF8))
            {
                while (!sr.EndOfStream)
                {
                    kategoriak.Add(new Kategoria(sr.ReadLine()));
                }
            }
        }
    }
}
