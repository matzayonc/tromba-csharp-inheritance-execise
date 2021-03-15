using System;
using System.Collections.Generic;
using System.Text;

namespace TrombaCastle
{
    class Pikeman: Soldier
    {
        public override string ReadyToFight()
        {
            return "Pikeman ready to fight!";
        }
        public override string ToString()
        {
            return "A Pikeman";
        }
    }
}
