using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class Bird : Animal, IBreed, INeed
    {
        private string breed;
        private bool specialNeeds;
        private string foodRequirements;

        public string Breed { get { return breed; } set { breed = value; } }
        public bool SpecialNeeds { get { return specialNeeds; } set { specialNeeds = value; } }
        public string FoodRequirements { get { return foodRequirements; } set { foodRequirements = value; } }

        public Bird(string id, string name, string gender, string age, string breed, string personalityType, bool specialNeeds, 
            string foodRequirements, double adoptionPrice) :base(id)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.breed = breed;
            this.PersonalityType = personalityType;
            this.specialNeeds = specialNeeds;
            this.foodRequirements = foodRequirements;
            this.AdoptionPrice = adoptionPrice;
            this.Category = "Small Animals";
        }

    }
}
