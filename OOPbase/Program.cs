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
            Console.ReadKey();
        }
    }
}
