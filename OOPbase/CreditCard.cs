using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    class CreditCard
    {
        Random RNG = new Random();
        private int cardNumber; //Номер кредитной карты
        public int CardNumber
        {
            set
            {
                cardNumber = value;
            }
            get
            {
                return cardNumber;
            }
        }
        private double balance;  //Баланс кредитной карты
        public double Balance
        {
            set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }
        public void MoneyWithDraw(double value) //Метод по снятию денег с карты
        {
            if (value > 0 && value <= balance)
            {
                balance = balance - value;
            }
            else if (value > balance)
            {
                Console.WriteLine("Not Enough Money on your credit card");
            }
            else
            {
                Console.WriteLine("Incorrect Value");
            }
        }
        public void MoneyPut(double value) //Метод по добавлению денег на карту
        {
            if (value > 0)
            {
                balance = balance + value;
            }
            else
            {
                Console.WriteLine("Incorrect Value");
            }
        }
        public void GetInfo() //Метод возращает данные о карте
        {
            Console.WriteLine($"{cardNumber}  {balance}");
        }
        public void CreateCreditCard() //Метод по созданию новой карты
        {
            Balance = 0;
            CardNumber = RNG.Next(1, 10000);
        }
    }
}
