using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Ad = "Ahmet";
            customer.Soyad = "Kemal";

            Customer customer1 = new Customer { Ad = "Ali", Soyad = "Cemal" };

            Customer[] a = new Customer[2] { customer, customer1 };


            CustomerManager manager = new CustomerManager();
            manager.Add(customer);
            manager.Update(customer1);
            manager.List(a);
            manager.Delete(customer1);
            Console.ReadLine();
        }
    }
}
