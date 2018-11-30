using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selbst_For
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            int i;

            Console.WriteLine("Gib eine Zahl ein");
            var zahl = Console.ReadLine();

            eingabe = Convert.ToInt32(zahl);

            for (i = eingabe; i > 0; i--)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i + " ist ein Zehner");
                }

                if (i%2 == 0)
                {
                    Console.WriteLine(i+ " ist Gerade");
                }

                if (i % 2 != 0)
                {
                    Console.WriteLine(i + " ist Ungerade");
                }
            }
            Console.ReadLine();
        }
    }
}
