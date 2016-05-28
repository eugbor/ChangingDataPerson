using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataPerson
{
    //creation of special events arguments
    //class contains the data of event OnNameChanged
    class NameChanged : EventArgs
    {
        public string NewName { get; private set; }
        public NameChanged(string newName)
        {
            this.NewName = newName;
        }
    }
}
