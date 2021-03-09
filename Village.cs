using System;
using System.Collections.Generic;
using System.Text;

namespace Tromba
{
    class Village: Settlement
    {
        public uint houseCount = 0;
        public Village() { }
        public Village(string name, uint amountOfhouses): base(name) 
        {
            houseCount = amountOfhouses;
        }

        public void burn()
        {
            houseCount = 0;
        }

        public uint countHouses()
        {
            return houseCount;
        }
    }
}
