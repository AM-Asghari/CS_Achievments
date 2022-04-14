using System;

namespace Les3SwitchCases
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int number = 0;
            try
            {
                number = Int32.Parse(input);
                switch (number)
                {
                    case 1:
                        Console.WriteLine("Congrats je koos zojuis het meest saaie getal op je toetsenbord!");
                        Console.ReadLine();
                        return;
                    case 2:
                        Console.WriteLine("Ik haat vrouwen - Mo circa 2022");
                        Console.ReadLine();
                        return;
                    default:
                        Console.WriteLine("Je hebt het getal " + number + " ingevoerd. Probeer 1 of 2 voor een andere tekst.");
                        Console.ReadLine();
                        return;
                }
            }
            catch
            {
                Console.WriteLine("Gast, letterlijk geen getal. Get gud");
            }
            Console.Read();
        }
    }
}