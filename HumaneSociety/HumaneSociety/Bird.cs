//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace HumaneSociety
//{
//    public class Bird : Animal, IBreed, INeed
//    {
//        private string breed;
//        private bool specialNeeds;
//        private string foodRequirements;

//        public string Breed { get { return breed; } set { breed = value; } }
//        public bool SpecialNeeds { get { return specialNeeds; } set { specialNeeds = value; } }
//        public string FoodRequirements { get { return foodRequirements; } set { foodRequirements = value; } }

//        public Bird(string id, string name, string gender, string age, string breed, string personalityType, bool specialNeeds,
//            string foodRequirements, double adoptionPrice) : base(id)
//        {
//            this.name = name;
//            this.gender = gender;
//            this.age = age;
//            this.breed = breed;
//            this.personalityType = personalityType;
//            this.specialNeeds = specialNeeds;
//            this.foodRequirements = foodRequirements;
//            this.adoptionPrice = adoptionPrice;
//            this.category = "Small Animals";
//        }
//    }
//}
