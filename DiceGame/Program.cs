using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus on kas magijat
            //Mõlemad mängijad viskavad täringut
            //Programm kontrollib, kumb mängija viskasa rohkem
            //Mängija, kes viskas rohkem on võiteja
            //Program kuulutab võitat
            Random rnd = new Random();            
            string Playerone = "Ted";
            string Playertwo = "Bob";
            int userThrow = rnd.Next(1, 7);
            int BobThrow = rnd.Next(1, 7);            
            Console.WriteLine($"Hello {Playerone} please press [enter] to roll your dice.");
            Console.ReadLine();
            Console.WriteLine($"{Playerone} rolled {userThrow}");
            Console.WriteLine($"Plese press [enter] again to roll for {Playertwo}.");
            Console.ReadLine();
            Console.WriteLine($"{Playertwo} rolled {BobThrow}.");
            if (userThrow > BobThrow)
            {
                Console.WriteLine($"{Playerone} wins! ");
            }
            else if  (userThrow < BobThrow)
            {
                Console.WriteLine($"{Playertwo} wins!");
            }
            else
            {
                Console.WriteLine("No one wins it's a draw!");
            }
            Console.ReadLine();

        }
    }
}
