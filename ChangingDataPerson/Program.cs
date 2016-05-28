using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangingDataPerson
{
    using System.Collections;
    using System.Runtime.CompilerServices;
   
    class Program
    {
        static void Main(string[] args)
        {
            // event registration
            Person person = new Person("Petr", 15);
            person.OnNameChanged += OnNameChanged;
            person.OnNameChanging += OnNameChanging;
            person.OnAgeChanged += OnAgeChanged;
            person.OnAgeChanging += OnAgeChanging;
            person.OnAgeError += OnAgeError;

            person.Name = "Igor";
            person.Age = 10;

            Console.ReadKey();
        }

        //receiving input parameters and receiving messages through the field
        static void OnNameChanged(object sender, NameChanged e)
        {
            Console.WriteLine("OnNameChanged to {0}", e.NewName);
            Console.WriteLine(new string('=', 79));
        }

        static void OnNameChanging(object sender, NameChanging e)
        {
            Console.WriteLine(new string('=', 79));
            Console.WriteLine("OnNameChanging from {0} to {1}", e.OldValue, e.NewValue);
            Console.WriteLine(new string('=', 79));
        }

        static void OnAgeChanged(object sender, AgeChanged e)
        {
            Console.WriteLine("OnAgeChanged to {0}", e.newAge);
            Console.WriteLine(new string('=', 79));
        }

        static void OnAgeChanging(object sender, AgeChanging e)
        {
            Console.WriteLine("OnAgeChanging from {0} to {1}", e.OldValue, e.NewValue);
            Console.WriteLine(new string('=', 79));
        }

        static void OnAgeError(object sender, AgeChanged e)
        {
            Console.WriteLine("Error! Incorrect value of age: {0}", e.newAge);
            Console.WriteLine(new string('=', 79));
        }

    }
}
