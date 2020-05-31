using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CustomerControlApplication
{
    class Customer
    {
        #region Fieldler
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerEmail { get; set; }
        public int Password { get; set; }
        #endregion
        #region Encapsulation for Kullanici adi
        private string _customerKullaniciAdi { get; set; }
        public string KullaniciAdi
        {
            get
            {
                return _customerKullaniciAdi;
            }
            set
            {
                bool KullaniciAdi = CustomerNameControl(value);
                if (KullaniciAdi)
                {
                    Console.WriteLine("Bu istifadeci adi artiq movcuddur.");
                    this._customerKullaniciAdi = string.Empty;

                }
                else
                {
                    _customerKullaniciAdi = value;
                }
            }
        }
        #endregion
        #region static memmbers
        static ArrayList CustomerArray;
        static Customer()
        {
            CustomerArray = new ArrayList();
        }
        static bool CustomerNameControl (string _customerKullaniciAdi)
        {
            bool control = false;
            for (int i = 0; i < CustomerArray.Count; i++)
            {
                Customer musteri = (Customer)CustomerArray[i];
            if (musteri.KullaniciAdi==_customerKullaniciAdi)
            {
                    control = true;
                    break;
            }          

            }
            return control;
        }
        public static void CustomerAdd(Customer customer)
        {
            if (customer!=null&& !string.IsNullOrEmpty(customer.KullaniciAdi)&& !string.IsNullOrEmpty(customer.CustomerEmail))
            {
                bool customerEmailcontrol = CustomerEmailControl(customer.CustomerEmail);
                if (customerEmailcontrol)
                {
                    Console.WriteLine("Bu email artiq movcuddur");
                }
                else
                {
                    CustomerArray.Add(customer);
                    Console.WriteLine("Adding succsesfully");
                }
            }
        }
        static bool CustomerEmailControl(string _email)
        {
            bool control = false;
            for (int i = 0; i < CustomerArray.Count; i++)
            {
                Customer musteri = (Customer)CustomerArray[i];
                if (musteri.CustomerEmail==_email)
                {
                     control = true;
                break;
                }
            }
            return control;
        }
        #endregion
    }
}
