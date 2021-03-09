using System;

namespace Övningar_2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Animals(2, 3, 5) + " Legs");
            Console.WriteLine(Animals(1, 2, 3) + " Legs");
            Console.WriteLine(Animals(5, 2, 8) + " Legs");
        }

        static int Animals(int chickens,int cows, int pigs)
        {
            return chickens * 2 + cows * 4 + pigs * 4;
        }
    }
}
