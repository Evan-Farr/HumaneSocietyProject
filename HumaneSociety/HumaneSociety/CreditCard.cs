using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class CreditCard
    {
        private string nameOnCard;
        private int cardNumber;
        private string expiration;
        private int cvc;
        private string billingAddress;

        public string NameOnCard;
        public int CardNumber { get { return cardNumber; } set { cardNumber = value; } }
        public string Expiration { get { return expiration; } set { expiration = value; } }
    }
}
