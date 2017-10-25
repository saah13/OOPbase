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
            Human human = new Human("Egor","Valere",33,332323,0.00);
            Console.WriteLine(human.IsAdult(human.Age));
            Console.WriteLine(human.IsSolvent(human.FirstName, human.LastName));
            Console.WriteLine(human.IsSolvent(human.CreditCardMoney));

            CreditCard creditcard = new CreditCard();
            creditcard.CardNumber = 1003013;
            creditcard.Balance = 1000;
            creditcard.MoneyWithDraw(500);
            creditcard.MoneyPut(400);
            Console.WriteLine(creditcard.Balance);
            Console.ReadKey();
        }
    }
}
