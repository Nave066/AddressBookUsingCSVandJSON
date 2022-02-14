using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCSVandJSON
{
    internal class Person
    {
        public string SSN;
        public string Name;
        public string Address;
        public string City;
        public string State;

        public Person()
        {
            Console.WriteLine("\nEnter Person details");
            Console.WriteLine("\nSSN :");
            SSN = Console.ReadLine();
            Console.WriteLine("\nName :");
            Name = Console.ReadLine();
            Console.WriteLine("\nAddress :");
            Address = Console.ReadLine();
            Console.WriteLine("\nCity :");
            City = Console.ReadLine();
            Console.WriteLine("\nState :");
            State = Console.ReadLine();
        }

        public Person(string ssn, string name, string addr, string city, string state)
        {
            SSN = ssn;
            Name = name;
            Address = addr;
            City = city;
            State = state;
        }
    }
}
