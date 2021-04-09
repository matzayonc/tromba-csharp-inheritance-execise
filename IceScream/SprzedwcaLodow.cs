using System;
using System.Collections.Generic;
using System.Text;

namespace IceScream
{
    class SprzedwcaLodow
    {
        FabrykaLodow fabryka;

        public SprzedwcaLodow(FabrykaLodow fabrykaLodow)
        {
            fabryka = fabrykaLodow;
        }

        public string ZaproponujSpecjalnoscDnia()
        {
            return "Dzisiaj specjalnośc dnia to: " + fabryka.sprawdzTrybProdukcji() + '.';
        }
    }
}
