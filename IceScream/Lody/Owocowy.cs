using System;
using System.Collections.Generic;
using System.Text;

namespace IceScream
{
    class Owocowy : Lody
    {
        bool wafel;
        bool polewa;

        public Owocowy(bool czyWWafelku=true, bool czyZPolewa=false): base(2, "Owocowy")
        {
            wafel = czyWWafelku;
            polewa = czyZPolewa;
        }


    }
}
