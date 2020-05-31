using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerControlApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Adding objects
            Customer customer = new Customer();
            customer.CustomerId = 1;
            customer.CustomerName = "Ulvi";
            customer.CustomerLastName = "Mecidov";
            customer.CustomerEmail = "UlviMacid@mail.ru";
            customer.KullaniciAdi = "UlviMacid";
            customer.Password = 123;
            Customer.CustomerAdd(customer);

            Customer customer1 = new Customer();
            customer1.CustomerId = 2;
            customer1.CustomerName = "Eli";
            customer1.CustomerLastName = "Aliyev";
            customer1.CustomerEmail = "AliEliyev@mail.ru";
            customer1.KullaniciAdi = "AliAli";
            customer1.Password = 123123;
            Customer.CustomerAdd(customer1);

            Customer customer2 = new Customer();
            customer2.CustomerId = 2;
            customer2.CustomerName = "Orxan";
            customer2.CustomerLastName = "Mecidov";
            customer2.CustomerEmail = "UlviMacid@mail.ru";
            customer2.KullaniciAdi = "UlviMacid1";
            customer2.Password = 123;
            Customer.CustomerAdd(customer2);
            #endregion
        }
    }
}
