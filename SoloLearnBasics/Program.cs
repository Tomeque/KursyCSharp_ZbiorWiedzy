using System;

namespace SoloLearnBasics
{
    class Person
    {
        // get set example
        private string name; //field

        public string Name //property
        {
            get { return name; }
            set { name = value; }
        }

        // statyczny konstruktor
    }

    class SomeClass
    {
        public static int X { get; set; }
        public static int Y { get; set; }

        static SomeClass()
        {
            X = 10;
            Y = 20;
            Console.WriteLine("test static constructor");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //passing by value example
            int a = 3;
            Sqr(a);
            Console.WriteLine(a);

            //passing by reference example
            a = 3;
            Sqr2(ref a);
            Console.WriteLine(a);

            // rekursja użyta do silni
            Console.WriteLine(Fact(6));

            // draw pyramid of any height to the console window using star (*) symbols.
            DrawPyramid(8);

            // get set example acces available only for public property, but not via private field
            Person p = new Person();
            p.Name = "Bob";
            Console.WriteLine(p.Name);

            // test static constructor
            Console.WriteLine(SomeClass.X);

            //generic method
            double x = 7.42;
            string y = "test";
            Func(x, y);

            // wyrażenia lambda
            Func<int, int, int> foo = (int ax, int ay) => { return ax + ay; };
            Func<int, int, int> foo_1 = (ax, ay) => ax + ay;
            Console.WriteLine(foo(5, 4));

            Console.ReadLine();
        }

        // generic method
        static void Func<T, U>(T x, U y)
        {
            Console.WriteLine(x + " " + y);
        }

        static void Sqr(int x)
        {
            x = x * x;
        }

        static void Sqr2(ref int x)
        {
            x = x * x;
        }

        static int Fact(int num)
        {
            if (num == 1)
            {
                return 1;
            }
            return num * Fact(num - 1);
        }

        static void DrawPyramid(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = i; j <= n; j++)
                {
                    Console.Write("  ");
                }
                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*" + " ");
                }
                Console.WriteLine();
            }
        }
    }
}



