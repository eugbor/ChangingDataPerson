using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataPerson
{
    //creation of special events arguments
    //class contains the data of event OnNameChanging
    class NameChanging : EventArgs
    {
        public string NewValue { get; private set; }
        public string OldValue { get; private set; }

        public NameChanging(string newValue, string oldValue)
        {
            this.NewValue = newValue;
            this.OldValue = oldValue;
        }
    }
}
