using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPbase
{
    sealed class Handycapped : Passenger
    {
        public Handycapped() : base(50)
        {

        }
        public override void PayForPassage()
        {
            CreditCard.WithdrawMoney(CityMoney.MetroHandycappedPaymentPrice);
            CityMoney.Invest(CityMoney.MetroHandycappedPaymentPrice);
        }
    }
}
