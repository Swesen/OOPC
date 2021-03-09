using System;
using System.Collections.Generic;
using System.IO;

namespace Program
{
    internal class SolSysBody
    {
        // Uppgift 1.a: skapa (bygg ut) SolSysBody så att den kan
        //     lagra en himlakropp (solar system body)

        // Uppgift 1.c: skapa en metod som skriver ut en himlakropp

        // Uppgift 1.f: ändra i SolSysBody så att den använder enumen
        //      i uppgift 1.e!
    }

    // Uppgift 1.e: skapa en enum som kan representera stjärna/planet/måne
    internal class Program
    {
        private static void Main()
        {
            List<SolSysBody> solsystem = new List<SolSysBody>();
            using (StreamReader fileStr = new StreamReader("..\\..\\..\\planeter.lis"))
            {
                string line;
                while ((line = fileStr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    // Uppgift 1.b: lägg in raden i variabeln solsystem
                }
            }
            Console.WriteLine("---- Lista på himlakroppar ----");
            // Uppgift 1.d: skriv ut alla himlakroppar

            Console.WriteLine("---- Lista på planeter ----");
            // Uppgift 1.g: skriv ut alla planeter

            Console.WriteLine("Press any key ...");
            Console.ReadKey();
        }
    }
}