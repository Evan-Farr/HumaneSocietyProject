using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Cat : Animal, IBreed, INeed, IMedical
    {
        private string breed;
        private bool specialNeeds;
        private string foodRequirements;
        private bool spayedNeutered;
        private bool shots;

        public string Breed { get { return breed; } set { breed = value; } }
        public bool SpecialNeeds { get { return specialNeeds; } set { specialNeeds = value; } }
        public string FoodRequirements { get { return foodRequirements; } set { foodRequirements = value; } }
        public bool SpayedNeutered { get { return spayedNeutered; } set { spayedNeutered = value; } }
        public bool Shots { get { return shots; } set { shots = value; } }

        public Cat(string name, string gender, int age, string breed, string personlityType, double adoptionPrice)
        {
            this.ID = SetUniqueID();
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.breed = breed;
            this.PersonalityType = personalityType;
            this.AdoptionPrice = adoptionPrice;
            this.Category = "Cats";
        }

        public int SetUniqueID()
        {
            return ID;
        }

        public void GetSpayedNeutered()
        {

        }

        public void GetShots()
        {

        }
    }
}
