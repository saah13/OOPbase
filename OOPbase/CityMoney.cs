using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    static class CityMoney
    {
        static double Budget { get; set; } = 1000;
        public const Double MetroDefaultPaymentPrice = 5;
        public const Double MetroHandycappedPaymentPrice = 2;

        public static void Invest(double value)
        {
            if (value >= 0)
            {
                Budget += value;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Withdaw value must be possitive,provided value:{value}");
            }
        }
        public static void Withdraw(double value)
        {
            if (value >= 0)
            {
                Budget -= value;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Withdaw value must be possitive,provided value:{value}");
            }

        }
    }

}
