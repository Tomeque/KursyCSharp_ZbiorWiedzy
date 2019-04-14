using System;
using System.Collections.Generic;
using System.Text;

namespace DelegatyOrg
{
    public delegate void NameChangedDelegate(object sender, NameChangedEventArgs args); 
    //sender: dzienniczek - czyli obiekt tej klasy (Diary) wywołuje zmianę i jego przekażemy
}
