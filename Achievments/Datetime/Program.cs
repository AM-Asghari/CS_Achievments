using System;
using System.Threading;

namespace Datetime
{
    class Program
    {
        static void Main()
        {
            int colorCounter = 0;
            int colorIndex = 0;

            ConsoleColor[] colors = { ConsoleColor.Red, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.DarkBlue, ConsoleColor.White, ConsoleColor.DarkYellow };
        
            while (true)
            {
                
                DateTime now = DateTime.Now;
                Console.Write("\r" + now.ToString("HH:mm:ss"));
                Thread.Sleep(1000);
                
                colorCounter++;
                
                if (colorCounter >= 3)
                { 
                    colorCounter = 0;
                    Console.ForegroundColor = colors[colorIndex];
                    colorIndex++;
                    if (colorIndex >= colors.Length) colorIndex = 0;
                }

            }
        }
    }
}
