using System;
using System.IO;
using System.Collections.Generic;

namespace Matcher

{
    class Match
    {
        // Uppgift 3.a: bygg ut klassen för att matcha matcher.lis
        // Uppgift 3.c: gör en utskriftsmetod för matchen
    }
    class Program
    {
        static void Main()
        {
            List<Match> match = new List<Match>();
            using (StreamReader fileStr = new StreamReader("..\\..\\..\\matcher.lis"))
            {
                string line;
                while ((line = fileStr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // Uppgift 3.b: lagra data i match
                }
            }
            Console.WriteLine("---- Inläst lista över matcher ----");
            // Uppgift 3.d: skriv ut alla matcher

            Console.WriteLine("---- Matcher med IFK Norrköping ----");
            // Uppgift 3.e: skriv ut alla matcher som spelats av IFK
            //              Norrköping

            // Uppgift 3.f: räkna ihop och skriv ut IFK Norrköpings
            //              alla mål under tidsperioden

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}
