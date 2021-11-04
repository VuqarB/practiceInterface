using System;
using System.Collections.Generic;
using System.Text;
using Animal.Abstractinterface;

namespace Animal.Models
{
    abstract class Animal
    {
        public abstract void Eat();
        public abstract void Breath();
        public abstract void Drink();
        public abstract void Live();
        public abstract void Sleep();
    }
}
