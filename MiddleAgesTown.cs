using System;
using System.Collections.Generic;
using System.Text;

namespace Tromba
{
    class MiddleAgesTown: Town
    {
        public MiddleAgesTown(string name, int population): base(name, population)
        { }

        public void burnAWitch()
        {
            base.population -= 1;
        }
    }
}
