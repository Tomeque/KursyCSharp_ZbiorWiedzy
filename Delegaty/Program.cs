using System;

namespace Delegaty
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochod skoda = new Samochod();

            skoda.ProbaDelegatu += new DelegateProba(OnNameDisplayed);

            skoda.Nazwa = "Skoda";
            Console.WriteLine("Wypisanie z konsoli: " + skoda.Nazwa); //najpierw zadziała delegat, poźniej to wypisanie
            
            Console.ReadKey();
        }

        private static void OnNameDisplayed(string existingValue)
        {
            Console.WriteLine($"dodatkowy tekst - powtórzona nazwa: {existingValue}.");
        }
    }
}
