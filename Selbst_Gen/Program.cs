using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_jeffrey_games
{
    class Program
    {
        static void Main(string[] args)
        {
           string optionen = "";
            while (optionen != "Q")
            {

            Console.WriteLine("Was wollen Sie machen?");
            Console.WriteLine();
            Console.WriteLine("A: Lottozahlen");
            Console.WriteLine("B: Ungerade/Gerade");
            Console.WriteLine("C: Rechnen");
            Console.WriteLine("Q: Beenden");
            Console.WriteLine();



            optionen = Console.ReadLine();

            

            switch (optionen)
            {

                case "A":
                    Random rand = new Random();

                    Console.WriteLine();

                    Console.WriteLine("Geben sie eine Menge an Lottozahlen an: ");
                    int max = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine();

                    for (int i = 1; i <= max; i++)
                    {
                        int randomZahl = rand.Next(1, 45);

                        Console.WriteLine("Die " + i + ". Lottozahl ist " + randomZahl);

                    }
                    Console.ReadLine();
                    break;


                case "B":
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
                    break;

                case "C":

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
                    }
                    System.Console.ReadLine();
                    break;

                }

            }
        }
    }
}