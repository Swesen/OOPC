using System;
using System.Linq;

namespace Program
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int?[] nullable = new int?[] { 2, null, 23, 19, 40, null, 8, null, null, -5 };
            /* Uppgift 2.a. Förklara: vad betyder '?' i det här sammanhanget? */
            // ? betyder att platsen i integer arrayen som normalt endast kan vara ett nummer också kan vara "null"
            /* Uppgift 2.b. Räkna ut följande parametrar av alla värden som är satta i
                  arrayen: maximum, minimum, summa
             */
            int max = (int)nullable.Max();
            int min = (int)nullable.Min();
            int sum = (int)nullable.Sum();

            /* Uppgift 2.c. Räkna ut medelvärdet */
            int nonNullVal = 0;
            foreach (var value in nullable)
            {
                if (value != null)
                {
                    nonNullVal++;
                }
            }
            double average = (double)sum / nonNullVal;

            /* Uppgift 2.d. Räkna ut standardavvikelsen
                  https://en.wikipedia.org/wiki/Standard_deviation
             */
            double[] deviation = new double[nonNullVal];
            int currentIndex = 0;
            for (int i = 0; i < deviation.Length; i++)
            {
                for (int j = currentIndex; j < nullable.Length; j++)
                {
                    if (nullable[j] != null)
                    {
                        deviation[i] = (int)nullable[j];
                        currentIndex = j;
                    }
                }
            }

            for (int i = 0; i < deviation.Length; i++)
            {
                deviation[i] = Math.Pow(deviation[i] - average, 2);
            }

            int standardDeviation = (int)Math.Round(Math.Sqrt(deviation.Average()));

            Console.WriteLine($"Maximum: {max}, Minumum: {min}, Summa: {sum}, Medelvärde: {average}, Standardavvikelse: {standardDeviation}");
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}