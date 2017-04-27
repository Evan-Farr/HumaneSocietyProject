using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Adopter
    {
        private string iD;
        private string firstName;
        private char middleInitial;
        private string lastName;
        private string streetAddress;
        private string email;
        private string phone;
        private CreditCard billing;
        private string personality;
        private bool smallChildren;
        private bool otherAnimals;
        private int numberOfOtherAnimals;
        private string typeOfOtherAnimals;
        private Animal interestedInAdopting;

        public string ID { get { return iD; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public char MiddleInitial { get { return middleInitial; } set { middleInitial = value; } }
        public string LastName { get { return lastName; } set { lastName = value; } }
        public string StreetAddress { get { return streetAddress; } set { streetAddress = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public CreditCard Billing { get { return billing; } set { billing = value; } }
        public string Personality { get { return personality; } set { personality = value; } }
        public bool SmallChildren { get { return smallChildren; } set { smallChildren = value; } }
        public bool OtherAnimals { get { return otherAnimals; } set { otherAnimals = value; } }
        public int NumberOfOtherAnimals { get { return numberOfOtherAnimals; } set { numberOfOtherAnimals = value; } }
        public string TypeOfOtherAnimals { get { return typeOfOtherAnimals; } set { typeOfOtherAnimals = value; } }
        public Animal InterestedInAdopting { get { return interestedInAdopting; } set { interestedInAdopting = value; } }

        public Adopter()
        {

        }
    }
}
