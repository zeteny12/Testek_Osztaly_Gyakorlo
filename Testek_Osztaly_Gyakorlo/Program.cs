using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testek_Osztaly_Gyakorlo
{
    internal class Program
    {
        //Lista
        static List<Test> lista = new List<Test>();
        static void Main(string[] args)
        {
            //Adatok listahoz fuzese
            lista.Add(new Henger(5.2, 10));
            lista.Add(new Kocka(3.1));
            lista.Add(new Teglatest(6, 2, 3.6));

            //Kiiratas
            foreach (var item in lista)
            {
                //Henger
                if (item.GetType().Equals(typeof(Henger))) //Feltetel, hogy 'Henger'-e
                {
                    Henger henger = (Henger)item;
                    Console.WriteLine($"A {item.TestNev} felszíne: {item.Felszin()} egység -- a {item.TestNev} térfogata: {item.Terfogat()} egység");
                }
                //Kocka
                else if (item.GetType().Equals(typeof(Kocka)))
                {
                    Kocka kocka = (Kocka)item;
                    Console.WriteLine($"A {item.TestNev} felszíne: {item.Felszin()} egység -- a {item.TestNev} térfogata: {item.Terfogat()} egység");
                }
                //Teglatest
                else if (item.GetType().Equals(typeof(Teglatest)))
                {
                    Teglatest teglatest = (Teglatest)item;
                    Console.WriteLine($"A {item.TestNev} felszíne: {item.Felszin()} egység -- a {item.TestNev} térfogata: {item.Terfogat()} egység");
                }
            }

            Console.ReadKey();
        }
    }
}
