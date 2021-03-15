using System;
using System.Collections.Generic;
using System.Text;

namespace Tromba
{
    class Town: Settlement
    {
        protected int population;
        public Town(string name, int numberOfPeople): base(name)
        {
            population = numberOfPeople;
        }

        public void census()
        { 
            Console.WriteLine("In the city of " + base.name + " lives " + population + " people.");
        }
    }
}
