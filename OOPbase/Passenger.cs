using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
     class Passenger : Human
    {
        private int stressMeter;//Показатель стресса 
        public int StressMeter
        {
            set
            {
                stressMeter = value;
            }
            get
            {
                return stressMeter;
            }
        }
        public Passenger(int startStress) //Создаем параметрический конструктор
        {
            stressMeter = startStress;
            CreditCard.PutMoney(100);
        }
        public Passenger(string firstName, string lastName, int age, int startStress) : base(firstName, lastName, age)
        {
            stressMeter = startStress;
            CreditCard.PutMoney(1000);
        }
        public override void PayForPassage()
        {
            CreditCard.WithdrawMoney(CityMoney.MetroDefaultPaymentPrice);
            CityMoney.Invest(CityMoney.MetroDefaultPaymentPrice);
        }

    }
}
