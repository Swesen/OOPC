using System;

namespace Program
{
    // Uppgift 2.a: gör en metod som skriver ut en matris (double[,])
    //              som är 3x3 stor, annars en felutskrift

    // Uppgift 2.c: gör en metod som adderar två matriser m1 och m2
    //              och skapar och returnerar en ny matris som innehåller
    //              summa-matrisen, formeln för varje summa-matris-element
    //              msum är msum[x,y] = m1[x,y] + m2[x,y]
    internal class Program
    {
        private static void Main()
        {
            double[,] M1 = new double[,] { { 1, 2, -1 }, { 3, 1, 0 }, { 2, 3, -1 } };
            double[,] M2 = new double[,] { { 2, 0, -0.4 }, { 2, 2.3, 1 }, { 1, 3.3, 2 } };
            double[,] I = new double[,] { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1 } };
            // Uppgift 2.b: utskrift av M1, M2 och I

            // Uppgift 2.d: anropa additionsfunktionen för att skapa en ny
            //              matris Msum och skriv ut den nya matrisen

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();
        }
    }
}