using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek_Osztaly_Gyakorlo
{
    internal class Henger : Test
    {
        //Adatok
        readonly double sugar;
        readonly double magassag;

        //
        public double Sugar => sugar;

        public double Magassag => magassag;

        //Tovabbkuldes
        public Henger(double sugar, double magassag) 
            : base("Henger")
        {
            this.sugar = sugar;
            this.magassag = magassag;
        }

        //Felszin, Terfogat szamitas
        public override double Felszin()
        {
            return 2 * Math.PI * sugar*(sugar + magassag);
        }

        public override double Terfogat()
        {
            return Math.PI * sugar * sugar * magassag;
        }
    }
}
