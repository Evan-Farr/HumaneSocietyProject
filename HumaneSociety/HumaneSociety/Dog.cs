﻿using System;
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

        public Dog(string iD, string name, string gender, int age, string breed, string personlityType, bool specialNeeds, string foodRequirements,
            bool spayedNeutered, bool shots, double adoptionPrice) :base(iD)
        {
            this.Name = name;
            this.Gender = gender;
            this.Age = age;
            this.breed = breed;
            this.PersonalityType = personalityType;
            this.specialNeeds = specialNeeds;
            this.spayedNeutered = spayedNeutered;
            this.shots = shots;
            this.AdoptionPrice = adoptionPrice;
            this.Category = "Dogs";
        }

        public void GetSpayedNeutered()
        {
            this.spayedNeutered = true;
        }

        public void GetShots()
        {
            this.shots = true;
        }
    }
}
