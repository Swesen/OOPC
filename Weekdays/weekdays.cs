using System;

namespace Program
{
    internal class Program
    {
        private enum WeekDay
        {
            Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
        }

        private static void Main()
        {
            /* Uppgift 3.a. refaktorera bort användningen av variabeln 'ix'
                   men fortsätt använda en for-loop */
            for (WeekDay wd = WeekDay.Monday; wd <= WeekDay.Sunday; wd++)
            {
                Console.WriteLine(wd);
            }
            /* Uppgift 3.b. använd en foreach-loop i stället */
            foreach (WeekDay day in Enum.GetValues(typeof(WeekDay)))
            {
                Console.WriteLine(day);
            }
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}