using System;
using Animal.Models;
using Animal.Abstractinterface;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Fish fish = new Fish();

            Console.WriteLine(fish.AnimalSwim());

        }
    }
}
