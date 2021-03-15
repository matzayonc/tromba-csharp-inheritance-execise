using System;
using System.Collections.Generic;
using System.Text;

namespace TrombaCastle
{
    class Crossbowman: Soldier
    {
        public override string ReadyToFight()
        {
            return "Crossbowman ready to fight!";
        }
        public override string ToString()
        {
            return "A Crossbowman";
        }
    }
}
