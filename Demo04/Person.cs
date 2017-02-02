using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo04
{
    class Person
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Address { get; set; }
        public int Age { get; set; }

        public Person(string, firstname, lastname)
        {
            Firstname = firstname;
            Lastname = lastname;

        public void PersonMethod()
        {
            Console.WriteLine("This method belongs to some property");
        }

        public override string ToString()
        {
            return Firstname + " " + Lastname " " + Address + " " + Age + " ";
        }

    }
    }
}
