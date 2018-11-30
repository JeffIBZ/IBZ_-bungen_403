using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selbst_Test
{
    class Program
    {
        static void Main(string[] args)
        {

            int eingabe1;
            int eingabe2;

            System.Console.WriteLine("Geben Sie eine Zahl ein");
            var nr1 = System.Console.ReadLine();

            eingabe1 = Convert.ToInt32(nr1);

            System.Console.WriteLine("Geben Sie eine zweite Zahl ein");
            var nr2 = System.Console.ReadLine();

            eingabe2 = Convert.ToInt32(nr2);

            if (eingabe1 < eingabe2)
            {
                Console.WriteLine("Die zweite Zahl ist grösser (" + eingabe2 + ")");
            }

            if (eingabe1 > eingabe2)
            {
                Console.WriteLine("Die erste Zahl ist grösser (" + eingabe1 + ")");
            }

            Console.WriteLine("Die Division von "+eingabe1+ " / " +eingabe2+ " ist " +eingabe1 / eingabe2);
            Console.WriteLine("Der Rest ist " +eingabe1 % eingabe2);
            Console.ReadLine();
        }
    }
}
