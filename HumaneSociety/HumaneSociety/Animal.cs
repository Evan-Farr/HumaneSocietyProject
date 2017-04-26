using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public abstract class Animal
    {
        protected int iD;
        protected string name;
        protected string gender;
        protected int age;
        protected string personalityType;
        protected double adoptionPrice;
        protected string category;

        public int ID { get { return iD; } set { iD = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Gender { get { return gender; } set { gender = value; } }
        public int Age { get { return age; } set { age = value; } }
        public string PersonalityType { get { return personalityType; } set { personalityType = value; } }
        public double AdoptionPrice { get { return adoptionPrice; } set { adoptionPrice = value; } }
        public string Category { get { return category; } set { category = value; } }

        public Animal()
        {
            this.iD = SetUniqueID();
        }

        public int SetUniqueID()
        {
            return iD;
        }
    }
}
