using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes_Sınıflar_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();
            ProductManager productManager =new ProductManager();
            productManager.Add();
            productManager.Update();
            customerManager.Add();
            customerManager.Update();
            Customer customer = new Customer();
            customer.Name = "Ali";
            customer.Lastame = "Ahmet";
            customer.City = "Mardin";
            customer.Id = 1;
            Console.WriteLine(customer.Name);
            Console.ReadLine();
        }

    }


   
    


}
