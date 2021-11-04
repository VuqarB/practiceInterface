using System;
using System.Collections.Generic;
using System.Text;
using Animal.Abstractinterface;

namespace Animal.Models
{
    class Reptile : Animal, ICrawl, IWalk
    {
        public override void Breath()
        {
            throw new NotImplementedException();
        }

        public override void Drink()
        {
            throw new NotImplementedException();
        }

        public override void Eat()
        {
            throw new NotImplementedException();
        }

        public override void Live()
        {
            throw new NotImplementedException();
        }

        public override void Sleep()
        {
            throw new NotImplementedException();
        }
    }
}
