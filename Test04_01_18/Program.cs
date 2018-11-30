using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test04_01_18
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                int Radius1;
                int Radius2;
                double PI = 3.14;

                System.Console.WriteLine("Geben Sie die erste Ganzzahl ein");
                var r1 = System.Console.ReadLine();

                Radius1 = Convert.ToInt32(r1);

                System.Console.WriteLine("Geben Sie die zweite Ganzzahl ein");
                var r2 = System.Console.ReadLine();

                Radius2 = Convert.ToInt32(r2);

                if (Radius1 < Radius2)
                {
                    System.Console.WriteLine("Berechnung Kreis mit Radius: " + Radius2);
                    System.Console.WriteLine("Umfang: " + 2 * Radius2 * PI);
                    System.Console.WriteLine("Fläche: " + Radius2 * Radius2 * PI);
                    Console.ReadLine();
                }
                else
                {

                    System.Console.WriteLine("Berechnung Kreis mit Radius: " + Radius1);
                    System.Console.WriteLine("Umfang: " + 2 * Radius1 * PI);
                    System.Console.WriteLine("Fläche: " + Radius1 * Radius1 * PI);
                    Console.ReadLine();
                }

            }
        }
    }
}

