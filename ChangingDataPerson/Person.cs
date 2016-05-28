using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataPerson
{
    class Person
    {
        // fields
        private string name;
        private int age;
        
        // constructor
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        // events
        public event EventHandler<NameChanging> OnNameChanging;
        public event EventHandler<NameChanged> OnNameChanged;

        public event EventHandler<AgeChanging> OnAgeChanging;
        public event EventHandler<AgeChanged> OnAgeChanged;

        public event EventHandler<AgeChanged> OnAgeError;

        // properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (this.OnNameChanging != null)
                {
                    this.OnNameChanging(this, new NameChanging(value, this.name));
                }

                this.name = value;

                if (this.OnNameChanged != null)
                {
                    this.OnNameChanged(this, new NameChanged(value));
                }
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 1)
                {
                    // call error event for the ages
                    this.OnAgeError(this, new AgeChanged(value));
                    throw new Exception(string.Format("Incorrect value of age [{0}]", value));
                }

                if (value > 100)
                {
                    // call exception for the age
                    throw new Exception(string.Format("Incorrect value of age [{0}]", value));
                }

                if (this.OnAgeChanging != null)
                {
                    this.OnAgeChanging(this, new AgeChanging(value, this.age));
                }

                this.age = value;

                if (this.OnAgeChanged != null)
                {
                    this.OnAgeChanged(this, new AgeChanged(value));
                }
            }
        }
    }
}
