using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    static class DataGenerator
    {
        private static string[] Names = { "aaron", "abdul", "abe", "abel", "abraham", "adam", "adan", "adolfo", "adolph", "adrian", "abby", "abigail", "adele", "adrian" }; //Мужские имена
        private static string[] lastNames = { "abbott", "acosta", "adams", "adkins", "aguilar" }; //Фамилии

        static DataGenerator()
        {
            rand = new Random();
        }
        private static Random rand;
        internal static string RandFirstName() //Метод по генерации случайного имени 
        {
            return Names[rand.Next(0, Names.Length)];
        }
        internal static string RandLastName() //Метод по генерации случайной фамилии
        {
            return lastNames[rand.Next(0, lastNames.Length)];
        }
        internal static int RandAge() //Метод по генерации случайного возраста
        {
            return rand.Next(1, 90);
        }


    }
}
