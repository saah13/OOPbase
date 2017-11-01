using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    class DataGenerator
    {
       private string[] Names = { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian" , "abby", "abigail", "adele", "adrian" }; //Мужские имена
       private string[] lastNames = { "abbott", "acosta", "adams", "adkins", "aguilar" }; //Фамилии

        internal string RandName() //Метод по генерации случайного имени 
        {
            return Names[new Random().Next(0, Names.Length)];
        }
        internal string RandLastName() //Метод по генерации случайной фамилии
        {
            return lastNames[new Random().Next(0, lastNames.Length)];
        }
        internal int RandAge() //Метод по генерации случайного возраста
        {
            return new Random().Next(1, 90); 
        }


    }
}
