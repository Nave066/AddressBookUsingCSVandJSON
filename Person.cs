using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

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

            string path = @"C:\Users\jayam\source\repos\AddressBookUsingCSVandJSON\AddressBookUsingCSVandJSON\Files\AddressBookTextFile.txt";
            string lines;
            using (StreamWriter sr = File.AppendText(path))
            {
                sr.WriteLine("{0},{1},{2},{3}", SSN, Name, Address, City, State);
                sr.Close();
                lines = File.ReadAllText(path);
                Console.WriteLine(lines);

            }
            //string importFilePath = @"C:\Users\vgj24\source\repos\AddressBookProject10FebAssgn\Adressbokkcsv\AddressBookCSV.csv";
            //string exportFilePath = @"C:\Users\vgj24\source\repos\AddressBookProject10FebAssgn\Adressbokkcsv\writeAddressBookCSV.csv";
            //using (var reader = new StreamReader(importFilePath))
            //using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            //{
            //    var records = csv.GetRecords<Person>().ToList();
            //    Console.WriteLine("Read data successfully from Adress Book csv.");
            //    foreach (Person person in records)
            //    {
            //        Console.Write("\t" + SSN);
            //        Console.Write("\t" + Name);
            //        Console.Write("\t" + Address);
            //        Console.Write("\t" + Age);

            //        Console.WriteLine("**********************Reading fromcsv file and Write to csv file **************************");
            //        //Writing json file
            //        JsonSerializer serializer = new JsonSerializer();
            //        using (StreamWriter sw = new StreamWriter(exportFilePath))
            //        using (JsonWriter writer = new JsonTextWriter(sw))
            //        {
            //            serializer.Serialize(writer, records);
            //        }
            //    }

            //}

        }
    }
}
