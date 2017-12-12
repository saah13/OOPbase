using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    abstract class Human
    {
        #region Fields
        private int age;
        private string firstName;
        private string lastName;
        #endregion
        #region Properties
        public string FirstName//Имя человека
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
        public string LastName //Фамилия человека
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
        public int Age//Возраст человека
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
        protected CreditCard CreditCard { get; private set; }
        #endregion

        public Human(string firstName = null, string lastName = null, int age = 0)
        {
            this.firstName = firstName ?? DataGenerator.RandFirstName();
            this.lastName = lastName ?? DataGenerator.RandLastName();
            this.age = age == 0 ? DataGenerator.RandAge() : age;
            CreditCard = new CreditCard($"{firstName} {lastName}");
        }

        public abstract void PayForPassage();
        public void Move()
        {

        }

    }
}