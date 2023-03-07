using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Dersleri_Değer_Tipleri
{
    internal class Program
    {

        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Add();
            customerManager.Update();
            Console.ReadLine();



            Customer customer = new Customer();
            customer.Id = 1;
            customer.FirstName = "Mustafa";
            customer.LastName = "Doğan";
            customer.City = "İstanbul";

            Customer customer2 = new Customer
            {
                Id = 2, City = "Ankara", LastName = "Gazi", FirstName = "Ali"
            };
            

            

        }
    }


}
