using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    class Human
    {
        private string firstName; //Имя человека
        public string FirstName
        {
            protected set
            {
                firstName = value;
            }
            get
            {
                return firstName;
            }
        }
        private string lastName; //Фамилия человека
        public string LastName
        {
            protected set
            {
                lastName = value;
            }
            get
            {
                return lastName;
            }
        }
        private int age; //Возраст человека
        public int Age
        {
            internal protected set
            {
                age = value;
            }
            get
            {
                return age;
            }
        }


    }
}