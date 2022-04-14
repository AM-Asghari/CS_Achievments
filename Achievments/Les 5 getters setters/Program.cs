using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Jedi jedi = new Jedi();
            jedi.SetName("Anakin Skywalker");
            Console.WriteLine($"Jedi name is {jedi.Name}");
        }
    }

    public class Jedi
    {
        internal string Name;

        internal void SetName(string name)
        {
            this.Name = name;
        }

    }

}