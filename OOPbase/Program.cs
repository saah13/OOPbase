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
            List<int> names = new List<int>();
            for (int i = 0; i < 5000; i++)
            {
                names.Add(DataGenerator.RandAge());
            }
            names = names.OrderBy(f => f).Reverse().ToList();

            creditcard.PutMoney(4000);
            creditcard.WithdrawMoney(500);
            creditcard.GetInfo();
            Console.WriteLine(DataGenerator.RandAge());
            Console.ReadKey();
        }
    }
}
