using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public class HumaneSociety
    {
        public Dictionary<Animal, string> animals;

        public HumaneSociety()
        {
            animals = new Dictionary<Animal, string>();
        }

        public string GenerateUniqueID()
        {
            Random random = new Random();
            int newRandom = random.Next(100000);
            for (int i = 0; i < animals.Count; i++)
            {
                if (newRandom.Equals(i))
                {
                    GenerateUniqueID();
                }
            }
            string ID = newRandom.ToString();
            return ID;
        }

        public void IntakeAnimal(Animal animal)
        {
            animals.Add(animal, animal.ID);
        }

        public void SpayNeuter(IMedical animal)
        {
            animal.SpayedNeutered = true;
        }

        public void GiveShots(IMedical animal)
        {
            animal.Shots = true;
        }

        public void DeClaw(Cat cat)
        {
            cat.DeClawed = true;
        }
    }
}
