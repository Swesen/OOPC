using System;

namespace Övning_2._4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Write("Vad heter du? ");
            Console.WriteLine(Greeting(Console.ReadLine()));
        }

        public static string Greeting(string name)
        {
            if (name == "Mubashir")
            {
                return "Hello, my Love!";
            }
            return "Hello, " + name + "!";
        }
    }
}