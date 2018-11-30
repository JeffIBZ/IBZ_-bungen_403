using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe_6
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

            if((eingabe1 > 0) & (eingabe2 > 0) & (eingabe1 < 100) & (eingabe2 < 100));
            {
                System.Console.WriteLine("Wochenende");
            
            else
	        {
                System.Console.WriteLine("Try again");
            };


        }   
    }
}
