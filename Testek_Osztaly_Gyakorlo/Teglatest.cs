using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek_Osztaly_Gyakorlo
{
    internal class Teglatest : Test
    {
        //Adatok
        readonly double oldalA;
        readonly double oldalB;
        readonly double oldalC;

        //
        public double OldalA => oldalA;
        public double OldalB => oldalB;
        public double OldalC => oldalC;

        //Tovabbkuldes
        public Teglatest(double oldalA, double oldalB, double oldalC) 
            : base("Téglatest")
        {
            this.oldalA = oldalA;
            this.oldalB = oldalB;
            this.oldalC = oldalC;
        }

        //Felszin, Terfogat szamitas
        public override double Felszin()
        {
            return 2 * (oldalA * oldalB + oldalA * oldalC + oldalB * oldalC);
        }

        public override double Terfogat()
        {
            return oldalA * oldalB * oldalC;
        }
    }
}
