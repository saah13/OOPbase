using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    class Human
    {
        public string FirstName { get; set; } //Имя человека
        public string LastName { get; set; } //Фамилия человека
        public int Age { get; set; } //Возраст человека
        public int CreditCardNumber { get; set; } //Номер кредитной карты человека
        public double CreditCardMoney { get; set; } //Баланс кредитной карты человека

        public Human(string firstName, string lastName, int age, int creditCardNumber, double creditCardMoney) // Создаем параметрический конструктор
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            CreditCardNumber = creditCardNumber;
            CreditCardMoney = creditCardMoney;
        }


        public bool IsSolvent(double CreditCardNumber) //Метод проверяющий по номеру карты может ли человек заплатить за проезд
        {
            if (CreditCardMoney >= 5)
            {
                return true;
            }
            else return false;
        }
        public bool IsSolvent(string FirstName, string LastName) //Метод проверяющий по имени и фамилии может ли человек заплатить за проезд
        {
            if (CreditCardMoney >= 5)
            {
                return true;
            }
            else return false;
        }

        public bool IsAdult(int Age) //Метод проверяющий совершеннолетний ли человек
        {
            if (Age >= 18)
            {
                return true;
            }
            else return false;
        }
    }
}