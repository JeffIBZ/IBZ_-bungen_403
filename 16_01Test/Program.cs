using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_01Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string optionen = "";
            while (optionen != "Q")
            {

                Console.WriteLine("Was wollen Sie ausführen");
                Console.WriteLine("Z: Zufallszahl raten");
                Console.WriteLine("W: Wuerfel berechnen");
                Console.WriteLine("M: Mittelwert berechnen");
                Console.WriteLine("Q: Beenden");


                optionen = Console.ReadLine();



                switch (optionen)
                {

                    case "Z":
                        Random rand = new Random();

                            int randomZahl = rand.Next(1, 100);

                            Console.WriteLine("Eine Zufallszahl zwischen 1 und 100 wurde erstellt");
                            Console.WriteLine("Sie können die Zufallszahl nun erraten. Geben Sie Ihren Tipp ein.");
                        for (int i = 1;; i++)
                        {

                            int rateversuch = Convert.ToInt32(Console.ReadLine());
                            

                            if (rateversuch < randomZahl)
                            {
                                
                                Console.WriteLine("Die von Ihnen eingegebene Zahl ist zu klein");
                                continue;
                            }
                           
                            if (rateversuch > randomZahl)
                            {
                                Console.WriteLine("Die von Ihnen eingegebene Zahl ist zu gross");
                                continue;
                            }

                            if (rateversuch == randomZahl)
                            {
                                Console.WriteLine("Sie benötigten " +i+ " Versuche, um die richtige Zahl herauszufinden");
                                break;
                            }
                            }
                        
                        Console.ReadLine();
                        break;


                    case "W":
                        int seite;


                        Console.WriteLine("Geben Sie eine positive Ganzzahl für die Seitenlaenge des Wuerfels ein:");
                        var nummer1 = Console.ReadLine();

                        seite = Convert.ToInt32(nummer1);

                        double flaeche = 6 * Math.Pow(seite, 2);
                        double volumen = Math.Pow(seite, 3);

                        Console.WriteLine("Seitenlaenge: " + seite + ", Oberflaeche:" + flaeche + ", Volumen:" + volumen);
                        Console.ReadLine();
                        break;

                    case "M":



                        Console.WriteLine("Geben Sie die erste Zahl ein");
                        int zahl1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Geben Sie die zweite Zahl ein");
                        int zahl2 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Der berechnete Mittelwert ist: " zahl1 + zahl2 / 2);
                        Console.ReadLine();
                        break;
                }

            }
        }
    }
}
