using System;
using System.Collections.Generic;
using System.Text;

namespace Tromba
{
    class Settlement
    {
        public string name { get; }

        public Settlement()
        {
            name = "Unnamed";
        }
        public Settlement(string nameOfSettlement)
        {
            name = nameOfSettlement;
        }

        public void welcome()
        {
            Console.WriteLine("Welcome in " + name + '!');
        }
    }
}
