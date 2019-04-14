using System;
using System.Collections.Generic;
using System.Text;

namespace Delegaty
{
    public class Samochod
    {
        private string _nazwa;

        public string Nazwa
        {
            get
            {
                ProbaDelegatu(_nazwa);
                return _nazwa;
            }
            set
            {
                _nazwa = value;
            }
        }

        public DelegateProba ProbaDelegatu; //to pole musi być w ramach klasy
    }
}
