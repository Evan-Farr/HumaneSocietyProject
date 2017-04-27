using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class Connection
    {
        public static void SaveChanges()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            try
            {
                database.SubmitChanges();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void SearchBySpecies()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine("\nInput the species you are looking for: ");
            string species = Console.ReadLine().ToLower();
            var matches = database.Animals.Where(n => n.Species.ToLower() == species).OrderBy(f => f.Name).Select(s => s);
            if (matches != null)
            {
                Console.WriteLine("SEARCH RESULTS: ");
                foreach (var match in matches)
                {
                    Console.WriteLine("> " + match + "\n");
                }
            }
            else
            {
                Console.WriteLine("> No Matches Found.");
                UI.Menu();
            }
        }

        public static void SearchByAnimalName()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine("\nInput the animal's name: ");
            string name = Console.ReadLine().ToLower();
            var matches = database.Animals.Where(n => n.Name.ToLower() == name).OrderBy(f => f.Name).Select(s => s);
            if (matches != null)
            {
                Console.WriteLine("SEARCH RESULTS: ");
                foreach (var match in matches)
                {
                    Console.WriteLine("> " + match + "\n");
                }
            }
            else
            {
                Console.WriteLine("> No Matches Found.");
                UI.Menu();
            }
        }

        public static void SearchByCharacteristics()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal animal = UI.GetKnownCharacteristics();
            var results = new List<Animal>();
            var matches1 = database.Animals.Where(n => n.Species.ToLower() == animal.Species);
            if (matches1 != null)
            {
                foreach(var match in matches1)
                {
                    results.Add(match);
                }
            }
            var matches2 = database.Animals.Where(a => a.Name.ToLower() == animal.Name);
            if (matches2 != null)
            {
                foreach (var match in matches2)
                {
                    results.Add(match);
                }
            }
            var matches3 = database.Animals.Where(g => g.Gender.ToLower() == animal.Gender);
            if (matches3 != null)
            {
                foreach (var match in matches3)
                {
                    results.Add(match);
                }
            }
            var matches4 = database.Animals.Where(p => p.Age == animal.Age);
            if (matches4 != null)
            {
                foreach (var match in matches4)
                {
                    results.Add(match);
                }
            }
            var matches5 = database.Animals.Where(b => b.Breed.ToLower() == animal.Breed);
            if (matches5 != null)
            {
                foreach (var match in matches5)
                {
                    results.Add(match);
                }
            }
            var matches6 = database.Animals.Where(s => s.Size.ToLower() == animal.Size);
            if (matches6 != null)
            {
                foreach (var match in matches6)
                {
                    results.Add(match);
                }
            }
            var matches7 = database.Animals.Where(t => t.Personality_Type.ToLower() == animal.Personality_Type);
            if (matches7 != null)
            {
                foreach (var match in matches7)
                {
                    results.Add(match);
                }
            }
            var matches8 = database.Animals.Where(z => z.Special_Needs == animal.Special_Needs);
            if (matches8 != null)
            {
                foreach (var match in matches8)
                {
                    results.Add(match);
                }
            }
            var matches9 = database.Animals.Where(y => y.Recieved_Shots == animal.Recieved_Shots);
            if (matches9 != null)
            {
                foreach (var match in matches9)
                {
                    results.Add(match);
                }
            }
            IEnumerable<Animal> Results = results.Distinct();
            var groupedResults = Results.GroupBy(q => q.Species).ToList();
            foreach(var result in groupedResults)
            {
                Console.WriteLine("> " + result + "\n");
            }
        }

        public static void SearchByAdopterName()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine("\nInput adopter's last name: ");
            string name = Console.ReadLine().ToLower();
            var matches = database.Adopters.Where(n => n.Last_Name.ToLower() == name).OrderBy(f => f.First_Name).Select(s => s);
            if(matches != null)
            {
                Console.WriteLine("SEARCH RESULTS: ");
                foreach (var match in matches)
                {
                    Console.WriteLine("> " + match + "\n");
                }
            }else
            {
                Console.WriteLine("> No Matches Found.");
                UI.Menu();
            }
            
        }

        public static void AddAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal animal = UI.GetNewAnimalInfo();
            //database.InsertAnimal(animal);
            database.Animals.InsertOnSubmit(animal);
        }

        public static void AddAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Adopter adopter = UI.GetNewAdopterInfo();
            database.Adopters.InsertOnSubmit(adopter);
        }

        public static void RemoveAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void RemoveAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void GiveShots(Animal animal)
        {

        }
    }
}
