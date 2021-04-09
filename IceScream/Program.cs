using System;

namespace IceScream
{
    class Program
    {
        static void Main(string[] args)
        {
            FabrykaLodow lodziarnia = new FabrykaLodow();
            SprzedwcaLodow sprzedawca = new SprzedwcaLodow(lodziarnia);

            lodziarnia.UstawTrybProdukcji(Smaki.Smietankowe, false, false);
            Console.WriteLine(sprzedawca.ZaproponujSpecjalnoscDnia());
            Console.WriteLine(sprzedawca.ZaproponujSpecjalnoscDnia());
            Console.WriteLine(sprzedawca.ZaproponujSpecjalnoscDnia());

            lodziarnia.UstawTrybProdukcji(Smaki.Wloskie, true);
            Console.WriteLine(sprzedawca.ZaproponujSpecjalnoscDnia());
        }
    }
}
