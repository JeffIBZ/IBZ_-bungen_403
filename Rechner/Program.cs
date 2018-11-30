using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechner
{
    class Program
    {
        static void Main(string[] args)
        {
            int eingabe1;
            int eingabe2;
  
          


            System.Console.WriteLine("Geben sie eine Ganze Zahl ein");
            var zahl1 = System.Console.ReadLine();

            eingabe1 = Convert.ToInt32(zahl1);

            System.Console.WriteLine("Geben sie eine 2. Ganze Zahl ein");
            var zahl2 = System.Console.ReadLine();

            eingabe2 = Convert.ToInt32(zahl2);

            System.Console.WriteLine("Wählen sie einen Operator (+, -, *, /)");
            string operationen = System.Console.ReadLine();


             int summe;

            

            switch (operationen)
            {
                case "+":
                    summe = eingabe1 + eingabe2;
                    System.Console.WriteLine("Das ist das Resultat:");
                    System.Console.WriteLine(+summe);


                    break;
                case "-":
                    summe = eingabe1 - eingabe2;
                    System.Console.WriteLine("Das ist das Resultat:");
                    System.Console.WriteLine(+ summe);
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
           
            
            System.Console.ReadLine();


        }
    }
}
