using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek_Osztaly_Gyakorlo
{
    abstract class Test
    {
        //Test neve
        public string TestNev;

        //Konstruktor
        protected Test(string testNev)
        {
            TestNev = testNev;
        }

        //Szukseges adatok
        public abstract double Felszin();
        public abstract double Terfogat();
    }
}
