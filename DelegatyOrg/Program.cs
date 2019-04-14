using System;

namespace DelegatyOrg
{
    // dalagaty z lekcji 25 zmienione na eventy w lekcji 26

    class Program
    {
        static void Main(string[] args)
        {
            Diary diary = new Diary();
            //diary.NameChengaed += new NameChangedDelegate(OnNameChanged);
            diary.NameChengaed += OnNameChanged; //inna prostsza składnia

            diary.Name = "Dzienniczek Marcina";

            Console.WriteLine(diary.Name);
            Console.ReadKey();
        }

        private static void OnNameChanged(object sender, NameChangedEventArgs args)
        {
            Console.WriteLine($"Zmiana nazwy z {args.ExistingName} na {args.NewName}");
        }
    }
}
// CTRL K, D - code cleanup