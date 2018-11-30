using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorenSchleife
{
    class Program
    {
        static void Main(string[] args)
        {

            int eingabe1;
            int eingabe2;
            int summe;


            do
            {
                Console.WriteLine("Geben Sie eine Zahl ein");
                var zahl1 = Console.ReadLine();

                eingabe1 = Convert.ToInt32(zahl1);

                Console.WriteLine("Geben Sie eine zweite Zahl ein");
                var zahl2 = Console.ReadLine();

                eingabe2 = Convert.ToInt32(zahl2);

                Console.WriteLine("Wählen Sie einen der folgenden Operatoren: + - / * ");
                string myoperator = Console.ReadLine();

                switch (myoperator)
                {
                    case "+":
                        summe = eingabe1 + eingabe2;
                        System.Console.WriteLine("Das ist das Resultat:");
                        System.Console.WriteLine(+summe);


                        break;
                    case "-":
                        summe = eingabe1 - eingabe2;
                        System.Console.WriteLine("Das ist das Resultat:");
                        System.Console.WriteLine(+summe);
                        break;
                    case "/":
                        summe = eingabe1 / eingabe2;
                        System.Console.WriteLine("Das ist das Resultat:");
                        System.Console.WriteLine(+summe);
                        break;
                    case "*":
                        summe = eingabe1 * eingabe2;
                        System.Console.WriteLine("Das ist das Resultat:");
                        System.Console.WriteLine(+summe);
                        break;
                    default:
                        Console.WriteLine("Default case");
                        break;
                }

                Console.WriteLine("Nochmal?");
                Console.WriteLine("j / n?");
                string wiederholung = Console.ReadLine();

                if (wiederholung != "j")
                {
                    break;
                }

            }

            while (true); 

            
        }
    }
}
