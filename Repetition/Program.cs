using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            {

            int zahl1;
            int zahl2;
            int resultat;

            System.Console.WriteLine("Geben Sie die erste Ganzzahl ein");
            var nr1 = System.Console.ReadLine();

            zahl1 = Convert.ToInt32(nr1);

            System.Console.WriteLine("Geben Sie die zweite Ganzzahl ein");
            var nr2 = System.Console.ReadLine();

            zahl2 = Convert.ToInt32(nr2);

            System.Console.WriteLine("Geben Sie die Operation ein.");
            System.Console.WriteLine("% für Modulo");
            System.Console.WriteLine("+ für Addition");
            System.Console.WriteLine("V für Vergleich");

            string myOperator = System.Console.ReadLine();

                switch (myOperator)
                {
                    case "%":
                        resultat = zahl1 % zahl2;
                        System.Console.WriteLine("Modulo von " + zahl1 + " % " + zahl2 + " ist " + resultat);
                        Console.ReadLine();
                        break;
                    case "+":
                        resultat = zahl1 + zahl2;
                        System.Console.WriteLine("Adition von " + zahl1 + " + " + zahl2 + " ist " + resultat);
                        Console.ReadLine();
                        break;
                    case "V":
                        if (zahl1 == zahl2)
                        {
                            System.Console.WriteLine("Die Zahlen sind gleich gross");
                        }
                        if (zahl1 > zahl2)
                        {
                            System.Console.WriteLine("Die erste Zahl ist grösser");
                        }
                        if (zahl1 < zahl2)
                        {
                            System.Console.WriteLine("Die zweite Zahl ist grösser");
                        }
                        Console.ReadLine();
                        break;
                }
            }


        }
    }
}
