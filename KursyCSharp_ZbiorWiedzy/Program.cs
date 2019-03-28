using System;

namespace KursyCSharp_ZbiorWiedzy
{
    class Samochod
    {
        // get set - zapis do pól klasy bez konieczności tworzenia metod get, set
        public string marka { get; set; }
        public int rok_produkcji { get; set; }

        public Samochod(string marka, int rok_produkcji)
        {
            this.marka = marka;
            this.rok_produkcji = rok_produkcji;
        }
    }

    class Program
    {
        // do metody przez argument przekazywana jest kopia zmiennej! (odc. 3.17)
        static int PrzypiszNowaWartosc(int nowaWart)
        {
            nowaWart = 12345;
            return nowaWart;
        }

        static void Main(string[] args)
        {
            // do metody przez argument przekazywana jest kopia zmiennej! (odc. 3.17)
            int staraWartosc = 1;
            PrzypiszNowaWartosc(staraWartosc);
            Console.WriteLine(staraWartosc); //!!!
            Console.WriteLine(PrzypiszNowaWartosc(staraWartosc));
            Console.ReadLine();

            // użycie get, set
            Samochod skoda = new Samochod("Skoda", 2018);
            Console.WriteLine(skoda.marka);
            Console.WriteLine(skoda.rok_produkcji);
            Console.ReadLine();

            // zamiast if można stosować operator trójargumentowy - przypisze 0 jeśli true lub age gdy false
            int age = 0;
            var result = age == 0 ? 0 : age;

            // jeśli hello będzie null to name będzie Dawid
            string hello = null;
            var name = hello ?? "Dawid";

            //porównanie stringów 
            string name1 = "haha";
            string name2 = "hehe";
            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
        }
    }
}
