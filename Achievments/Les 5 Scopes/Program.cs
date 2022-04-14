using System;
using moedertjelief;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MOMMY MOEDER = new MOMMY();
            MOEDER.callYourMom();
        }
    }
    
}
namespace moedertjelief
{
    public class MOMMY
    {
        public void callYourMom()
        {
            string yourMom = "your mom is a nice lady";
            Console.WriteLine(yourMom);
        }
    }
}
