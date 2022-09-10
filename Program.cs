using System;

namespace ConsoleAppWinorLose
{
    class Program
    {
        static void Main(string[] args)
        {

            Beginning:

            //String Champion = "";
            String ReadGame = "";
            bool Resultat = true;
            int Winstreak = 0;
            int point = 20;

            

            Console.WriteLine("Hello press G and Enter to play and see if you will win!");
            ReadGame = Console.ReadLine();

        

            if (ReadGame == "G")
            {

            Start:
                Random rnd = new Random();
                int Game = rnd.Next(1, 3);


                Console.WriteLine("Hello press Enter to see if you will win!");
                Console.ReadLine();

                if (Game == 1)
                {
                    Resultat = true;
                    Winstreak += 1;
                    point += 20;
                }

                else if (Game == 2)
                {
                    Resultat = false;
                    Winstreak -= 1;
                    point -= 10;
                    if (Winstreak < 0)
                    {
                        Winstreak = 0;
                    }
                    if (point < 0)
                    {
                        point = 0;
                    }
                }

                Console.WriteLine(Resultat + ", Winstreak: " + Winstreak + ", Points: " + point + " Tryck Enter om du vill fortsätta");
                ReadGame = Console.ReadLine();

                if (ReadGame == "")
                {
                    goto Start;
                }
                
            }
        }
    }
}
