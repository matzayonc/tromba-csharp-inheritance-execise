using System;
using System.Collections.Generic;
using System.Text;

namespace IceScream
{
    class Wloski: Lody
    {
        bool wafel;
        bool posypka;

        public Wloski(bool czyWWafelku = true, bool czyZPosypka = false): base(2, "o smaku włosów")
        {
            wafel = czyWWafelku;
            posypka = czyZPosypka;
        }
    }
}
