using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2zähler
{
    class Program
    {
        static void Main(string[] args)
        {

            int summe = 0;

            Console.WriteLine("Geben Sie eine Zahl ein");
            int zahl1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Geben Sie eine Zahl ein");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            for (int i = zahl1; i <= zahl2; i++)
            {
                Console.Write(summe = summe + i);

            }

            Console.ReadLine();

        } 
    }
}
