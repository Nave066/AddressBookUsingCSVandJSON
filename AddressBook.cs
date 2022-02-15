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

        //UC3 Edit person details 
        public static Person find(string Name)
        {
            List<Person> listPersonInCity;
            listPersonInCity = new List<Person>();
            AddRecords(listPersonInCity);

            Person PersonFind = listPersonInCity.Find((StoringVariable) => StoringVariable.Name == Name);
            if (PersonFind != null)
            {
                Console.WriteLine("Name Found");
                Console.WriteLine("Edit this details:");
                Console.WriteLine("SSN :");
                string SSN = Console.ReadLine();
                Console.WriteLine("Address :");
                string Address = Console.ReadLine();
                Console.WriteLine("City:");
                string City = Console.ReadLine();
                Console.WriteLine("State:");
                string State = Console.ReadLine();
                listPersonInCity.ForEach(x => Console.WriteLine("{0}\t{1}\t{2}\t{3}\t{4}", x.Name.ToString(), x.SSN.ToString(), x.Address.ToString(), x.City.ToString(), x.State.ToString())); ;

            }
            else
            {
                Console.WriteLine("No record found for the name" + Name);

            }
            return PersonFind;
        }
        public static void edit(List<Person> listPersonInCity)

        {
            Console.WriteLine("enter name to edit");
            string Name = Console.ReadLine();
            AddressBook.find(Name);
        }

        //UC4 delete persons name using Console
        public static void DeletepersonName(List<Person> listPersonInCity)
        {
            Console.WriteLine("Enter name to be delete");
            string Name = Console.ReadLine();
            listPersonInCity.RemoveAll(e => e.Name == Name);
            // Console.WriteLine(listPersonInCity.ToString());
            Console.WriteLine("List After deletion of " + Name);
            listPersonInCity.ForEach(x => Console.WriteLine("{0}\t", x.Name.ToString()));

        }

        //UC5 and 6 are done already as the multiple contacts are added in the addressbook

        //UC7 Checking for dupicate entry
        public static void duplicateentry(List<Person> listPersonInCity)
        {
            Console.WriteLine("enter name to check duplicae entry");
            string Name = Console.ReadLine();
            if (listPersonInCity.Count(x => x.Name == Name) > 1)
            {
                Console.WriteLine(" there is duplicate entry for this name for " + listPersonInCity.Count(x => x.Name == Name) + "times");
            }
            else
            {
                Console.WriteLine("no duplicate entry for this name");
            }
        }
        //uc8 ,uc9 ,uc 10 to search multiple persons in same city or state
        public static void SameCityStateMates(List<Person> listPersonInCity)
        {
            Console.WriteLine("enter city to search  person in it");
            string Address = Console.ReadLine();
            int count = listPersonInCity.Count(x => x.Address == Address);
            Console.WriteLine("{0} person living in {1}", count, Address);

            foreach (Person person in listPersonInCity.FindAll(e => e.Address == Address))
            {
                Console.WriteLine("Name :" + person.Name);
            }

        }

        //UC11 sorted Adressbook by alphabetical names
        public static void SortData(List<Person> listPersonInCity)
        {

            listPersonInCity.Sort(delegate (Person x, Person y)
            {
                if (x.Name == null && y.Name == null) return 0;
                else if (x.Name == null) return -1;
                else if (y.Name == null) return 1;
                else return x.Name.CompareTo(y.Name);
            });
            Console.WriteLine("after sorting by name");
            foreach (Person person in listPersonInCity)
            {
                Console.WriteLine(person.Name);
            }
        }
        //UC12 Sorting the Addressbook by city
        public static void SortDatabyCity(List<Person> listPersonInCity)
        {

            listPersonInCity.Sort(delegate (Person x, Person y)
            {
                if (x.City == null && y.City == null) return 0;
                else if (x.City== null) return -1;
                else if (y.City == null) return 1;
                else return x.City.CompareTo(y.City);
            });
            Console.WriteLine("after sorting by name");
            foreach (Person person in listPersonInCity)
            {
                Console.WriteLine(" {0}\t {1} ", person.City, person.City);
            }
        }
    }
}
