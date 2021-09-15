using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //mängus on kaks mängijat
            //mõlemad mängijad viskavad täringut
            //programm kontrollib, kumb mängija viskas rohkem
            //mängija kes viskas rohkem ongi võitja
            //programm kuulutab võitjat

            Random Rnd = new Random();

            string playerOne = "Sina";
            string playerTwo = "Arvuti";

            int SinaThrow = Rnd.Next(1, 7);
            int ArvutiThrow = Rnd.Next(1, 7);

            Console.WriteLine($"{playerOne} threw {SinaThrow};");
            Console.WriteLine($"{playerTwo} threw {ArvutiThrow};");


            if (SinaThrow > ArvutiThrow)
            {
                Console.WriteLine($"{playerOne} wins!");
            }
            else if (SinaThrow < ArvutiThrow)
            {
                Console.WriteLine($"{playerTwo} wins!");
            }
            else
            {
                Console.WriteLine("Draw Let them try again");
            }
        }
    }
}
