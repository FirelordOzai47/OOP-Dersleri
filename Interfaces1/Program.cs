using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*InterfacesMethod();*/

            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add(new SqlDal());
            ICustomerDal[] customerDals = new ICustomerDal[]
            {
                new SqlDal(),
                new OracleDal(),
            };
            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
            }

            Console.ReadLine();




        }

        private static void InterfacesMethod()
        {
            PersonManager manager = new PersonManager();
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "ali",
                LastName = "Dede",
                Adress = "Yılzdız apt."
            };


            Student student = new Student { Id = 1, FirstName = "Ahmet", LastName = "derli", Department = "Fizik" };
            manager.Add(customer);
            manager.Add(student);
        }
    }

    interface IPerson
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
    }
    class Customer : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Adress { get; set; }
    }
    class Student : IPerson
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
    }
    class PersonManager 
    {
        public void Add(IPerson person
            )
        {
            Console.WriteLine(person.LastName);
        }
    }
}
