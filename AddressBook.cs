using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookUsingCSVandJSON
{
    internal class AddressBook
    {
        // UC1
        public static void AddRecords(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person("203456876", "John", "12 Main Street, Newyork,NY", "Newyork","Newyork"));
            listPersonInCity.Add(new Person("203456877", "SAM", "13 Main Ct, Newyork,NY", "Newyork", "Newyork"));
            listPersonInCity.Add(new Person("203456878", "Elan", "14 Main Street, Newyork,NY", "Newyork", "Newyork"));
            listPersonInCity.Add(new Person("203456879", "Smith", "12 Main Street, Newyork,NY", "Newyork", "Newyork"));
            listPersonInCity.Add(new Person("203456880", "SAM", "Senthil Nagar", "Uthangarai","Tamilnadu"));
            listPersonInCity.Add(new Person("203456881", "Sue", "32 Cranbrook Rd, Newyork,NY", "Newyork", "Newyork"));
            listPersonInCity.Add(new Person("203456882", "Winston", "1208 Alex st, Newyork,NY", "Newyork", "Newyork"));
            listPersonInCity.Add(new Person("203456883", "Naveen", "5th Street,Senthilnagar", "Perungudi","Chennai"));
            listPersonInCity.Add(new Person("203456884", "SAM", "126 Province Ave, Baltimore,NY", " Baltimore", " Baltimore"));
            Console.WriteLine(listPersonInCity.ToString());
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));

        }
        //UC2 to add person name using console
        public static void AddPerson(List<Person> listPersonInCity)
        {
            listPersonInCity.Add(new Person());
        }
    }
}
