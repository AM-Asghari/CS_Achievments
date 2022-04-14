using System;

namespace RekenMachine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rekenmachine rekenmachine = new Rekenmachine();
            Console.WriteLine("Wil je keer of plus doen?");
            string input = Console.ReadLine();
            if(input == "plus" || input == "Plus")
            {
                rekenmachine.optellen();
            }
            else if(input.ToLower() == "keer" )
            {
                rekenmachine.vermenigvuldigen();
            }           
        }
    }
    internal class Rekenmachine
    {
        public void optellen()
        {
            Console.WriteLine("Type het eerste getal in");
            int aPlus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type het tweede getal in");
            int bPlus = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aPlus + bPlus);
        }

        public void vermenigvuldigen()
        {

            Console.WriteLine("Type het eerste getal in");
            int aKeer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Type het tweede getal in");
            int bKeer = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(aKeer * bKeer);

        }
    }
}