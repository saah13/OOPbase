using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    class Passenger : Human
    {
        DataGenerator data = new DataGenerator();
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
            FirstName = data.RandName();
            LastName = data.RandLastName();
            Age = data.RandAge();
            stressMeter = startStress;
        }

    }
}
