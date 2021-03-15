using System;
using System.Collections.Generic;
using System.Text;

namespace Tromba
{
    class Capital: Town
    {
        public Capital(string name, int population): base(name, population)
        { }

        public void makeACoup()
        {
            population -= 460;
        }
    }
}
