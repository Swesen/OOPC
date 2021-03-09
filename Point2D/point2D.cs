using System;

namespace Program
{
    internal class Program
    {
        private class Point2D
        {
            /* 4.a. skapa en klass som representerar
                    en punkt i 2D-rymden, */
            public double X, Y;

            public Point2D(double X, double Y)
            {
                this.X = X;
                this.Y = Y;
            }

            /* 4.b-c. SE NEDAN! */
            /* 4.d. lägg till metoden här! */

            public double CalculateDistanceTo(Point2D P)
            {
                return Math.Sqrt(Math.Pow(this.X - P.X, 2) + Math.Pow(this.Y - P.Y, 2));
            }

            /* 4.e-f. SE NEDAN! */
            /* 4.g. lägg till metoden här! */

            public Point2D Middle(Point2D P)
            {
                return new Point2D(this.X - (this.X - P.X) / 2, this.Y - (this.Y - P.Y) / 2);
            }
        };

        private static void Main()
        {
            /* 4.b. skapa två punkter P1 <2.5,1.3> och P2 <0.3,3.1> */
            Point2D P1 = new Point2D(2.5, 1.3);
            Point2D P2 = new Point2D(0.3, 3.1);
            /* 4.c. räkna ut avståndet mellan dem och skriv ut */
            double Distance = P1.CalculateDistanceTo(P2);
            Console.WriteLine("Avstånd: " + Distance);
            /* 4.d. skapa en metod som räknar ut avståndet (SE OVAN!) */
            /* 4.e. använd metoden för att räkna ut och skriva avståndet */
            /* 4.f. räkna ut den punkt som ligger MITT EMELLAN dem,
                    skriv ut den */
            Point2D Middle = P1.Middle(P2);
            Console.WriteLine($"Centrumpunkt: X:{Middle.X}, Y:{Middle.Y}");
            /* 4.g. skapa en metod Middle(Point2D P) som returnerar
                    mittpunkten emellan objektet självt och P, använd,
                    skriv ut! */
            Console.WriteLine("Press any key to continue: ");
            Console.ReadKey();
        }
    }
}