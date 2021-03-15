using System;
using System.Collections.Generic;
using System.Text;

namespace TrombaCastle
{
    class Dweller
    {
        protected int hunger = 3;
        public int Eat()
        {
            return hunger;
        }

        public override string ToString()
        {
            return "A simple Dweller";
        }
    }
}
