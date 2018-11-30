using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selbst_While
{
    class Program
    {
        static void Main(string[] args)
        {
            int start;

            Console.WriteLine("Geben Sie eine positive Ganzzahl ein");
            var nummer1 = Console.ReadLine();

            start = Convert.ToInt32(nummer1);

            int min = 0;

            while (min <= start)
            {

                    if (min % 10 == 0)
                    {
                    Console.WriteLine(min++ + " ist ein Zehner");
                    continue;
                    }
                    if (min % 2 == 0)
                    {
                        Console.WriteLine(min++ + " ist Gerade");
                    }
                    if (min % 2 == 1)             
                    {
                        Console.WriteLine(min++ + " ist Ungerade");
                    }



            }
                Console.ReadLine();

        }
    }
}


