using System;
using System.IO;

namespace Textfilradsorterare
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string[] fileLines;

            Console.Write("Input file location: ");
            fileLines = File.ReadAllLines(Console.ReadLine());

            Console.Write("Output file location: ");
            string outputFileLocation = Console.ReadLine();

            Array.Sort(fileLines, StringComparer.InvariantCulture);

            File.WriteAllLines(outputFileLocation, fileLines);

            foreach (var item in fileLines)
            {
                Console.WriteLine(item);
            }
        }
    }
}