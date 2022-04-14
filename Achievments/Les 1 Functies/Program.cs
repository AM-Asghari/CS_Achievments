using System;
using System.Linq;

namespace Les_1_Functies
{

    public class StringDraaien
    {
        public static void DraaiStringOm(string Hello_World)
        {
            char[] reversed = Hello_World.Reverse().ToArray();
            foreach (char chr in reversed)
            {
                Console.Write(chr);
            }
        }
    }

    public class HalloZeggen
    {
        static void Main(string[] args)
        {
            StringDraaien.DraaiStringOm("Hello World");
            Console.WriteLine();
        }
    }
}