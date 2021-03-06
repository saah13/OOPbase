﻿using System;
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
            private set
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
            private set
            {
                balance = value;
            }
            get
            {
                return balance;
            }
        }
        private string holderName; //Имя владельца карты
        public string HolderName
        {
            private set
            {
                holderName = value;
            }
            get
            {
                return holderName;
            }
        }
        public void WithdrawMoney(double value) //Метод по снятию денег с карты
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
        public void PutMoney(double value) //Метод по добавлению денег на карту
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
            Console.WriteLine($"Your card number:{cardNumber}  Your balance:{balance}  Your name:{holderName}");
        }
        public CreditCard() //Создаем параметрический конструктор
        {
            cardNumber = RNG.Next(1, 5000);
            balance = 0;
        }
        public CreditCard(string holderName) //Создаем перегрузку параметрического конструктора
        {
            cardNumber = RNG.Next(1, 5000);
            balance = 0;
            HolderName = holderName;
        }
    }
}
