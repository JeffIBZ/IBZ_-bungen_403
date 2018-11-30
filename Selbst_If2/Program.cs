using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selbst_If2
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {


                int start = 0;
                int eingabe1;

                Console.WriteLine("Geben Sie eine positive Ganzzahl ein");
                var nummer = Console.ReadLine();

                eingabe1 = Convert.ToInt32(nummer);

                if (eingabe1 % 2 == 0)
                {
                    Console.WriteLine("Die Zahl ist Gerade");
                }

                if (eingabe1 % 2 != 0)
                {
                    Console.WriteLine("Die Zahl ist Ungerade");
                }


                Console.ReadLine();

            }

        }
    }
}
