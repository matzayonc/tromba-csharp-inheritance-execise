using System;
using System.Collections.Generic;
using System.Text;

namespace IceScream
{
    abstract class Lody
    {
        protected uint cena;
        protected string smak;

        protected Lody(uint cenaZaLod, string glownySmak)
        {
            cena = cenaZaLod;
            smak = glownySmak;
        }

        public string PelnaNazwa()
        {
            return "Lód " + smak;
        }
    }
}
