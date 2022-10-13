using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_TestGame.Concrete
{
    public class CustomerManager : ICustomManagerService
    {
        ICustomerTcIdentify _customerTcIdentify;
        public CustomerManager(ICustomerTcIdentify customerTcIdentify)
        {
            _customerTcIdentify = customerTcIdentify;
        }
        public void Add(Customer customer)
        {
            if (_customerTcIdentify.Identifier(customer))
            {
                Console.WriteLine("Başarıyla kayıt oldu.");
            }
            else
            {
                throw new Exception("Bilgiler doğru değil! Kayıt başarısız.");
            }
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
