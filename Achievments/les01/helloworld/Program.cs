using System;
using System.Threading;

namespace helloworld
{
    class Program
    {   
        static void Main(string[] args)
        {
            string[] helloworld = { "H", "e", "l", "l", "o", " W", "o", "r", "l","d","!" };

            for (int i = 0; i < helloworld.Length; i++) 
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(helloworld[i]);
                Thread.Sleep(1000);
            }
            Console.ReadLine();
        }
    }
}
