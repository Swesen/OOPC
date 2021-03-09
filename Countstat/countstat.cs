using System;
using System.Linq;

namespace Program
{
    internal class Program
    {
        private static void Main()
        {
            int[] statistics = new int[] { 2, 3, 23, 19, 40, -33, 8, 100, -200, -5 };
            /* Uppgift 1.a. Räkna ut följande parametrar av alla värden som är satta i
                  arrayen: maximum, minimum, summa
             */
            int max = statistics.Max();
            int min = statistics.Min();
            int sum = statistics.Sum();
            /* Uppgift 1.b. Räkna ut medelvärdet
                  https://en.wikipedia.org/wiki/Average
             */
            double average = statistics.Average();
            /* Uppgift 1.c. Räkna ut standardavvikelsen
                  https://en.wikipedia.org/wiki/Standard_deviation
             */
            double[] deviation = new double[statistics.Length];
            for (int i = 0; i < statistics.Length; i++)
            {
                deviation[i] = Math.Pow(statistics[i] - average, 2);
            }

            int standardDeviation = (int)Math.Round(Math.Sqrt(deviation.Average()));

            Console.WriteLine($"Maximum: {max}, Minumum: {min}, Summa: {sum}, Medelvärde: {average}, Standardavvikelse: {standardDeviation}");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}