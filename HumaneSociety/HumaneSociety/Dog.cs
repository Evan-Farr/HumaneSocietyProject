using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Dog : Animal, IBreed, INeed, IMedical
    {
        private string size;
        private string breed;
        private bool specialNeeds;
        private string foodRequirements;
        private bool spayedNeutered;
        private bool shots;

        public string Size { get { return size; } set { size = value; } }
        public string Breed { get { return breed; } set { breed = value; } }
        public bool SpecialNeeds { get { return specialNeeds; } set { specialNeeds = value; } }
        public string FoodRequirements { get { return foodRequirements; } set { foodRequirements = value; } }
        public bool SpayedNeutered { get { return spayedNeutered; } set { spayedNeutered = value; } }
        public bool Shots { get { return shots; } set { shots = value; } }

        public Dog(string id, string name, string gender, string age, string breed, string size, string personalityType, bool specialNeeds, string foodRequirements,
            bool spayedNeutered, bool shots, double adoptionPrice) :base(id)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.breed = breed;
            this.size = size;
            this.PersonalityType = personalityType;
            this.specialNeeds = specialNeeds;
            this.foodRequirements = foodRequirements;
            this.spayedNeutered = spayedNeutered;
            this.shots = shots;
            this.AdoptionPrice = adoptionPrice;
            this.Category = "Dogs";
        }
    }
}
