using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyOrg
{
    public class Diary
    {
        private string _name;

        public string Name
        {
            get
            {
                return _name.ToUpper();
            }
            set
            {
                if (_name != value)
                {
                    NameChangedEventArgs args = new NameChangedEventArgs();
                    args.ExistingName = _name;
                    args.NewName = value;

                    NameChengaed(this, args);
                }

                _name = value;
            }
        }

        public event NameChangedDelegate NameChengaed;
    }
}
