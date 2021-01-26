using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    public class CustomerManager
    {
        Customer musteri = new Customer();
        public void List(Customer[] customer)
        {

            foreach (Customer item in customer)
            {
                Console.WriteLine("Müşteri Adı :" + musteri.Ad);
                Console.WriteLine("Müsteri Soyadı :" + musteri.Soyad);
            }
        }
        public void Add(Customer customer)
        {
            Console.WriteLine("Eklendi");
        }
        public void Update(Customer customer)
        {
            Console.WriteLine("Güncellendi");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Silindi");
        }
    }
}
