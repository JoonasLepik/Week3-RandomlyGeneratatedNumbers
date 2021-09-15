using System;

namespace RandomNumberGenerators
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int RNG = rnd.Next(1, 11);//Number 1 kuni 10.
            Console.WriteLine($"Your Random number is {RNG}");

            //Programm kontollib, kas genereeritud number on suurem kui 5
            //kui genereeritud number on suurem kui 5, program kuvab
            //"juhulik number on {RNG}, see on suurem kui viis"
            //kui on väiksem kui viis siis:
            //"juhulik number on {RNG}, see on väiksem kui 5."
            // ja kui number on viis siis:
            // "juhulsik number on 5."
            //(< - väiksem kui) , (> - suurem kui) , (== - võrdne)
            if (RNG > 5)
            {
                Console.WriteLine($"Your Randomly generated number is {RNG}, It's bigger then 5.");
            }
            else if (RNG < 5)
            {
                Console.WriteLine($"Your Randomly generated number is {RNG}, It's smaler than 5.");
            }
            else
            {
                Console.WriteLine($"Your Randomly generated number is {RNG}."); 
            }
            Console.ReadLine();
            Console.WriteLine("Have a Nice day.");
        }
    }
}
