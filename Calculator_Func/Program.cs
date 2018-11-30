using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Func
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                double eingabe1;
                double eingabe2;

                System.Console.WriteLine("Geben sie eine Ganze Zahl ein");
                var zahl1 = System.Console.ReadLine();

                eingabe1 = Convert.ToDouble(zahl1);

                System.Console.WriteLine("Geben sie eine 2. Ganze Zahl ein");
                var zahl2 = System.Console.ReadLine();

                eingabe2 = Convert.ToDouble(zahl2);

                double resplus = addition(eingabe1, eingabe2);
                Console.WriteLine("Das Resultat der Addition ist:");
                Console.WriteLine(resplus);

                double resminus = subtraktion(eingabe1, eingabe2);
                Console.WriteLine("Das Resultat der Subtraktion ist:");
                Console.WriteLine(resminus);

                double resdurch = division(eingabe1, eingabe2);
                Console.WriteLine("Das Resultat der Division ist:");
                Console.WriteLine(resdurch);

                double resmal = multiplikation(eingabe1, eingabe2);
                Console.WriteLine("Das Resultat der Multiplikation ist:");
                Console.WriteLine(resmal);
                Console.ReadLine();
            }
            }

            static double addition(double eingabe1, double eingabe2)
            {
                return eingabe1 + eingabe2;
            }

            static double subtraktion(double eingabe1, double eingabe2)
            {
                return eingabe1 - eingabe2;
            }

            static double division(double eingabe1, double eingabe2)
            {
                return eingabe1 / eingabe2;
            }

            static double multiplikation(double eingabe1, double eingabe2)
            {
                return eingabe1 * eingabe2;
            }
        }
    } 
