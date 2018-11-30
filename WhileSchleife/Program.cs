using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileSchleife
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {

            

            int start;
            int ende;

            Console.WriteLine("Geben Sie eine positive Ganzzahl ein");
            var nummer1 = Console.ReadLine();

            start = Convert.ToInt32(nummer1);

            Console.WriteLine("Geben Sie eine zweite positive Ganzzahl ein");
            var nummer2 = Console.ReadLine();

            ende = Convert.ToInt32(nummer2);

            if (start <= ende)
            {

                    System.Console.WriteLine("**************");
                    System.Console.WriteLine("***DO***");
                    do
            {
                Console.WriteLine(start++);
            } while (start <= ende);
            {
            }
            Console.ReadLine();
            }
            else
            {
            do
            {
                Console.WriteLine(ende++);
            } while (start >= ende);
            {
            }

            }
                System.Console.WriteLine("**************");
                System.Console.WriteLine("***While***");
                while (start <= ende)
                {
                    Console.WriteLine(start++);
                }
                while (ende <= start)
                {
                    Console.WriteLine(ende++);
                }

            System.Console.WriteLine("Programm wiederholen?");
            string eingabe3 = Console.ReadLine();

            if (eingabe3 != "y")
            {
                    break;
            }
            }

           
        }
    }
}
