using System;
using System.Collections.Generic;
using System.Text;

namespace IceScream
{
    class Smietankowy: Lody
    {
        bool wafel;
        bool posypka;
        bool polewa;

        public Smietankowy(bool czyWWafelku=true, bool czyZPolewa=false, bool czyZPosypka=false): base(1, "Śmietankowy")
        {
            wafel = czyWWafelku;
            polewa = czyZPolewa;
            posypka = czyZPosypka;
        }
    }
}
