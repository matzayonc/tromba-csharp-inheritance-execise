using System;
using System.Collections.Generic;
using System.Text;

namespace TrombaCastle
{
    abstract class Soldier: Dweller
    {
        public abstract string ReadyToFight();
        public override string ToString()
        {
            return "A soldier without specialization";
        }
    }
}
