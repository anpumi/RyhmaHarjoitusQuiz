using System;
using System.Collections.Generic;
using System.Text;

namespace Kysymykset
{
    class Pelaaja
    {
        public string Nimi { get; set; }

        private int piste = 0;
        public Pelaaja()
        {
        }
        public void Pistelisäys()
        {
            piste++;
           
        }
        
    }
}
