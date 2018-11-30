using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchleifenBeispiel
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe;
            int eingabe1;

            Console.WriteLine("Gib eine Zahl ein");
            var zahl = Console.ReadLine();

            eingabe = Convert.ToInt32(zahl);

            Console.WriteLine("Gib noch eine Zahl ein");
            var zahl2 = Console.ReadLine();

            eingabe1 = Convert.ToInt32(zahl2);

            int min = 0;
            int max = 0;

            if (eingabe1 < eingabe)
            {
                max = eingabe;
                min = eingabe1;
            }
            else
            {
                max = eingabe1;
                min = eingabe; 
            }

                for (int i = min; i <= max; i++)
                {
                Console.WriteLine(i);
                }
            
            Console.ReadLine();
        }
    }
}
