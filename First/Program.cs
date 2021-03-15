using System;

namespace Tromba
{
    class Program
    {
        static void Main()
        {
            Settlement settlement = new Settlement("Świątniki górne");
            settlement.welcome();

            MiddleAgesTown krakow = new MiddleAgesTown("Kraków", 11);
            krakow.welcome();
            krakow.census();
            krakow.burnAWitch();
            krakow.census();

            Village village = new Village("Bieńczyce", 13);
            village.welcome();
            Console.WriteLine("There are " + village.countHouses() + " houses here.");

            Capital stolyca = new Capital("Gniezno", 10460);
            stolyca.welcome();
            stolyca.census();
            stolyca.makeACoup();
            stolyca.census();
        }
    }
}
