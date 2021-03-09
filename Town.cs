using System;
using System.Collections.Generic;
using System.Text;

namespace Tromba
{
    class Town: Settlement
    {
        int population;
        Town(string name, int numberOfPeople): base(name)
        {
            population = numberOfPeople;
        }

        public void census()
        {
            Console.WriteLine("In the city of " + base.name + " live " + population + "people.");
        }
    }
}
