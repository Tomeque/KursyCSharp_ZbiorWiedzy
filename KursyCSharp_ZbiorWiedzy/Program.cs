using System;

namespace KursyCSharp_ZbiorWiedzy
{
    class Program
    {
        static void Main(string[] args)
        {
            // zamiast if można stosować operator trójargumentowy - przypisze 0 jeśli true lub age gdy false
            int age = 0;
            var result = age == 0 ? 0 : age;

            // jeśli hello będzie null to name będzie Dawid
            string hello = null;
            var name = hello ?? "Dawid";


        }
    }
}
