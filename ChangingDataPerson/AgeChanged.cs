using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataPerson
{
    //creation of special events arguments    
    //class contains the data of event OnAgeChanged
    class AgeChanged : EventArgs
    {
        public int newAge { get; private set; }
        public AgeChanged(int newAge)
        {
            this.newAge = newAge;
        }
    }
}
