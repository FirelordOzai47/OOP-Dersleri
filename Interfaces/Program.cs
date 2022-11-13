using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

        
            InterfacesIntro();
            ICustomerDal[] customersDals = new ICustomerDal[2]
            {
                new MySqlServer(),
                new OracleServer(),

            };
            foreach (var customerDal in customersDals)
            {
                customerDal.Add();
            }


            Console.ReadLine();
        }

        private static void InterfacesIntro()
        {
            PersonManager manager = new PersonManager();
            Student student = new Student
            {
                Id = 2,
                FirstName = "ali",
                LastName = "düzgün",
                Class = "None"

            };
            Costumer costumer = new Costumer
            {
                Id = 1,
                FirstName = "mustafa",
                LastName = "Dogan",
                Adress = "None"

            };
            manager.Add(student);
        }
    }

    interface IPerson //soyut nesne
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }

    }
    class Student : IPerson // somut nesneler
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Class { get; set; }

    }

    class Costumer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class PersonManager
    {
        public void Add(IPerson person)
        {
            Console.WriteLine($"Soyadı:{person.LastName}");
        }
    }


}
