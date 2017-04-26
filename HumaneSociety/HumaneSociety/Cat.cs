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
        private bool deClawed;

        public string Breed { get { return breed; } set { breed = value; } }
        public bool SpecialNeeds { get { return specialNeeds; } set { specialNeeds = value; } }
        public string FoodRequirements { get { return foodRequirements; } set { foodRequirements = value; } }
        public bool SpayedNeutered { get { return spayedNeutered; } set { spayedNeutered = value; } }
        public bool Shots { get { return shots; } set { shots = value; } }
        public bool DeClawed { get { return deClawed; } set { deClawed = value; } }

        public Cat(string iD, string name, string gender, string age, string breed, string personalityType, bool specialNeeds, string foodRequirements,
            bool spayedNeutered, bool shots, bool deClawed, double adoptionPrice) :base(iD)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.breed = breed;
            this.PersonalityType = personalityType;
            this.specialNeeds = specialNeeds;
            this.foodRequirements = foodRequirements;
            this.spayedNeutered = spayedNeutered;
            this.shots = shots;
            this.deClawed = deClawed;
            this.AdoptionPrice = adoptionPrice;
            this.Category = "Cats";
        }
    }
}
