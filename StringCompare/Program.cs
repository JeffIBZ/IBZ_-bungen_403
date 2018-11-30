using System;

namespace StringCompare
{
    class Program
    {
        static void Main(string[] args)
        {
            string wort1;
            string wort2;
           
            

            System.Console.WriteLine("Geben sie ein Wort ein");
           wort1 = System.Console.ReadLine();

            System.Console.WriteLine("Geben sie eine zweites Wort ein");
            wort2 = System.Console.ReadLine();


            if (String.Compare (wort1, wort2))
              
            {
                System.Console.WriteLine("String 2 ist grösser");

            }

  

        }
    }
}
