using System;
using System.Collections.Generic;
using System.Text;
using Animal.Abstractinterface;

namespace Animal.Models
{
    class Fish : Animal, ISwim
    {
        public bool AnimalSwim()
        {
            bool fishes = true;
            if (fishes)
            {
                Console.WriteLine("Ok. I can swim faster");
            }
            return fishes;
        }

        public override void Breath()
        {
            Console.WriteLine("I can breath due to gill");
        }

        public override void Drink()
        {
            Console.WriteLine("I drink water in water");
        }

        public override void Eat()
        {
            Console.WriteLine("I eat grass and other fishes");
        }

        public override void Live()
        {
            Console.WriteLine("I live in water");
        }

        public override void Sleep()
        {
            Console.WriteLine("I sleep with other fishes");
        }
    }
}
