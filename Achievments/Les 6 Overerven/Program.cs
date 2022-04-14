using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    internal abstract class Animal
    {
        internal string Name { get; set; }
        protected Animal(string name)
        {
            this.Name = name;
        }
    }

    internal class Horse:Animal
    {
        internal bool biped { get; set; }
        internal Animal(bool Horse, string name) : base(name)
        {
            this.biped = biped;
        }
    }

}