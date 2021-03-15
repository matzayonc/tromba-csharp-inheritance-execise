using System;
using System.Collections.Generic;


namespace TrombaCastle
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Dweller> dwellers = new List<Dweller>();
            dwellers.Add(new Dweller());
            dwellers.Add(new Dweller());

            List<Soldier> soldiers = new List<Soldier>();
            soldiers.Add(new Pikeman());
            soldiers.Add(new Pikeman());

            List<Crossbowman> crossbowmen = new List<Crossbowman>();
            crossbowmen.Add(new Crossbowman());
            crossbowmen.Add(new Crossbowman());
            crossbowmen.Add(new Crossbowman());

            foreach(Crossbowman crossbowman in crossbowmen)
                soldiers.Add(crossbowman);

            foreach (Soldier soldier in soldiers)
                dwellers.Add(soldier);


            foreach (Crossbowman crossbowman in crossbowmen)
                Console.WriteLine(crossbowman.ReadyToFight());

            foreach (Soldier soldier in soldiers)
                Console.WriteLine(soldier.ReadyToFight());

            foreach (Dweller dweller in dwellers)
                Console.WriteLine(dweller.Eat());

        }
    }
}
