using System;

namespace Övning_2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($" At level {i}: {StackBoxes(i)} boxes"); 
            }
        }

        static int StackBoxes(int levelsOfBoxes)
        {
            int result = 0;
            int currentLevel = 0;
            for (int i = 1; i < levelsOfBoxes + 1; i++)
            {
                currentLevel += i;
                result += currentLevel;
            }
            return result;
        }
    }
}
