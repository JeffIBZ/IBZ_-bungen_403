using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KommaZahl
{
    class Program
    {
        static void Main(string[] args)
        {

            decimal eingabe1;
            decimal eingabe2;
            decimal summe;
            int summe2;



            Console.WriteLine("Schreibe die 1 Zahl");
            var nr1 = Console.ReadLine();

            eingabe1 = Convert.ToDecimal(nr1);

            System.Console.WriteLine("Schreibe die 2 Zahl");
            var nr2 = Console.ReadLine();

            eingabe2 = Convert.ToDecimal(nr2);

            summe = eingabe1 + eingabe2;

            System.Console.WriteLine("Das Resultat aus " + eingabe1 + " und " + eingabe2 + " ist " + summe);

            summe2 = Convert.ToInt32(summe);

            System.Console.WriteLine("Das Resultat als Ganzezahl aus " + eingabe1 + " und " + eingabe2 + " ist " + summe2);
            System.Console.ReadLine();
        }
    }
}
