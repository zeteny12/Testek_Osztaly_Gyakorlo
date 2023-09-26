using System;

namespace Testek_Osztaly_Gyakorlo
{
    internal class Kocka : Test
    {
        //Adat
        readonly double el;
        
        //
        public double El => el;

        //Tovabbkuldes
        public Kocka(double el) 
            : base("Kocka")
        {
            this.el = el;
        }

        //Felszin, Terfogat szamitas
        public override double Felszin()
        {
            return 6 * el * el;
        }

        public override double Terfogat()
        {
            return el * el * el;
        }
    }
}
