using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataPerson
{
    //creation of special events arguments
    //class contains the data of event OnAgeChanging
    class AgeChanging : EventArgs
    {
        public int NewValue { get; private set; }
        public int OldValue { get; private set; }

        public AgeChanging(int newValue, int oldValue)
        {
            this.NewValue = newValue;
            this.OldValue = oldValue;
        }
    }
}
