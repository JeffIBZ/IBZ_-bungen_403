using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_AddCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            int eingabe1;
            int eingabe2;
            int summe;

         

            Console.WriteLine("Schreibe die 1 Zahl");
            var nr1 = Console.ReadLine();
            
            eingabe1 = Convert.ToInt32(nr1);

            System.Console.WriteLine("Schreibe die 2 Zahl");
            var nr2 = Console.ReadLine();

            eingabe2 = Convert.ToInt32(nr2);

            summe = eingabe1 + eingabe2;


            System.Console.WriteLine("Das Resultat aus " +eingabe1+ " und "  +eingabe2+ " ist " +summe);
            System.Console.ReadLine();


        }
    }
}
