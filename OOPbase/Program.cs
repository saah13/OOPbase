using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    class Program
    {
        static void Main(string[] args)
        {

            CreditCard creditcard = new CreditCard("Valera");
            DataGenerator data = new DataGenerator();
            creditcard.PutMoney(4000);
            creditcard.WithdrawMoney(500);
            creditcard.GetInfo();
            Console.WriteLine(data.RandAge());
            Console.ReadKey();
        }
    }
}
