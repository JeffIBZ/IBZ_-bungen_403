using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_2
{
    class Program
    {
        static void Main(string[] args)
        {

            int zahl = 0;

            do
            {
            Console.WriteLine("Geben Sie eine Ganzzahl ein");
            zahl = Convert.ToInt32(Console.ReadLine());


            } while (zahl <=0);

            string[] myArr = new string[zahl];

            int i = 1;
            while (i <= zahl)
            {

                if ((i % 2) == 0)
                {
                    myArr[i - 1] = i + " ist gerade";
                }
                else
                {
                    myArr[i - 1] = i + " ist ungerade";
                }

                i++;
                
            }
            foreach (string tempElement in myArr)
            {
                Console.WriteLine(tempElement);
            }
            Console.ReadLine();
        }
        
    }
}
