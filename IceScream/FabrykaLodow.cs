using System;
using System.Collections.Generic;
using System.Text;

namespace IceScream
{
    enum Smaki
    {
        Pusty = 0,
        Smietankowe,
        Owocowe,
        Sorbety,
        Wloskie
    }


    class FabrykaLodow
    {
        private Smaki trybProdukcji = Smaki.Smietankowe;

        bool wafelek = false;
        bool posypka = false;
        bool polewa = false;


        public Lody SpecjalnoscDnia()
        {
            switch (trybProdukcji)
            {
                case Smaki.Smietankowe:
                    return new Smietankowy(wafelek, polewa, posypka);
                case Smaki.Owocowe:
                    return new Owocowy(wafelek, polewa);
                case Smaki.Sorbety:
                    return new Sorbet();
                case Smaki.Wloskie:
                    return new Wloski(wafelek, posypka);
                default:
                    return new Smietankowy(false, false, false);
                    
            }
        }

        public void UstawTrybProdukcji(Smaki smak, bool Wafelek=false, bool Posypka=false, bool Polewa=false)
        {
            trybProdukcji = smak;
            wafelek = Wafelek;
            posypka = Posypka;
            polewa = Polewa;
        }

        public string sprawdzTrybProdukcji()
        {
            string statusPosypki = posypka ? " z posypką" : "";
            string statusPolewy = polewa ? " z polewą" : "";
            string statusWafelka = wafelek ? " w wafelku" : " bez wafelka";
            string dodatki = statusPosypki + statusPolewy + statusWafelka;

            return SpecjalnoscDnia().PelnaNazwa() + dodatki;
        }
    }
}
