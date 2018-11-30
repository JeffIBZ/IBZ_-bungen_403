using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallStack_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int zahl1 = 10;
            int zahl2 = 20;
            int resultat = calculate(zahl1, zahl2);
            System.Console.WriteLine("Das Resultat ist: " + resultat);
            
        }


        static int calculate(int value1, int value2)
        {
            System.Console.WriteLine("Ich bin in Methode calculate");
            return value1 + value2;
        }
   

    }
}
