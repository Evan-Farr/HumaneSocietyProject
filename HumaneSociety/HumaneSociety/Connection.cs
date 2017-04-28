using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Console.WriteLine("Enter the species you are looking for: ");
            string species = Console.ReadLine().ToLower();
            var matches = database.Animals.Where(n => n.Species.ToLower() == species).OrderBy(f => f.ID).Select(s => s).ToList();
            if (matches != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in matches)
                {
                    Console.WriteLine("> ID: " + match.ID);
                    Console.WriteLine("> Species: " + match.Species);
                    Console.WriteLine("> Name: " + match.Name);
                    Console.WriteLine("> Gender: " + match.Gender);
                    Console.WriteLine("> Age: " + match.Age);
                    Console.WriteLine("> Breed: " + match.Breed);
                    Console.WriteLine("> Adult Size: " + match.Size);
                    Console.WriteLine("> Personality Type: " + match.Personality_Type);
                    Console.WriteLine("> Special-Needs: " + match.Special_Needs);
                    Console.WriteLine("> Food Requirements: " + match.Food_Requirments);
                    Console.WriteLine("> Spayed/Neutered: " + match.Spayed_or_Neutered);
                    Console.WriteLine("> Recieved Shots: " + match.Recieved_Shots);
                    Console.WriteLine("> Adoption Price: " + match.Adoption_Price);
                    Console.WriteLine("> Category: " + match.Category + "\n\n");
                }
            }
            else
            {
                Console.WriteLine("> No Matches Found.\n\n");
            }
            Console.WriteLine("Press [ENTER] to continue....");
            Console.ReadKey();
            Console.Clear();
            UI.Menu();
        }

        public static void SearchByAnimalName()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine("\nInput the animal's name: ");
            string name = Console.ReadLine().ToLower();
            var matches = database.Animals.Where(n => n.Name.ToLower() == name).OrderBy(f => f.Name).Select(s => s).ToList();
            if (matches != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in matches)
                {
                    Console.WriteLine("> ID: " + match.ID);
                    Console.WriteLine("> Species: " + match.Species);
                    Console.WriteLine("> Name: " + match.Name);
                    Console.WriteLine("> Gender: " + match.Gender);
                    Console.WriteLine("> Age: " + match.Age);
                    Console.WriteLine("> Breed: " + match.Breed);
                    Console.WriteLine("> Adult Size: " + match.Size);
                    Console.WriteLine("> Personality Type: " + match.Personality_Type);
                    Console.WriteLine("> Special-Needs: " + match.Special_Needs);
                    Console.WriteLine("> Food Requirements: " + match.Food_Requirments);
                    Console.WriteLine("> Spayed/Neutered: " + match.Spayed_or_Neutered);
                    Console.WriteLine("> Recieved Shots: " + match.Recieved_Shots);
                    Console.WriteLine("> Adoption Price: " + match.Adoption_Price);
                    Console.WriteLine("> Category: " + match.Category + "\n\n");
                }
            }
            else
            {
                Console.WriteLine("> No Matches Found.\n\n");
            }
            Console.WriteLine("Press [ENTER] to continue....");
            Console.ReadKey();
            Console.Clear();
            UI.Menu();
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
                if (results.Count != 0 && animal.Name != "")
                {
                    for (int i = 0; i < results.Count; i++)
                    { 
                        if (results[i].Name.ToLower() != animal.Name)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches3 = database.Animals.Where(g => g.Gender.ToLower() == animal.Gender);
            if (matches3 != null)
            {
                foreach (var match in matches3)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Gender != "")
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Gender.ToLower() != animal.Gender)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches4 = database.Animals.Where(p => p.Age == animal.Age);
            if (matches4 != null)
            {
                foreach (var match in matches4)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Age != 0)
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Age != animal.Age)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches5 = database.Animals.Where(b => b.Breed.ToLower() == animal.Breed);
            if (matches5 != null)
            {
                foreach (var match in matches5)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Breed != "" )
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Breed.ToLower() != animal.Breed)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches6 = database.Animals.Where(s => s.Size.ToLower() == animal.Size);
            if (matches6 != null)
            {
                foreach (var match in matches6)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Size != "")
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Size.ToLower() != animal.Size)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches7 = database.Animals.Where(t => t.Personality_Type.ToLower() == animal.Personality_Type);
            if (matches7 != null)
            {
                foreach (var match in matches7)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Personality_Type != "")
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Personality_Type.ToLower() != animal.Personality_Type)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches8 = database.Animals.Where(z => z.Special_Needs == animal.Special_Needs);
            if (matches8 != null)
            {
                foreach (var match in matches8)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Special_Needs != null)
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Special_Needs != animal.Special_Needs)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            var matches9 = database.Animals.Where(y => y.Recieved_Shots == animal.Recieved_Shots);
            if (matches9 != null)
            {
                foreach (var match in matches9)
                {
                    results.Add(match);
                }
                if (results.Count != 0 && animal.Special_Needs != null)
                {
                    for (int i = 0; i < results.Count; i++)
                    {
                        if (results[i].Recieved_Shots != animal.Recieved_Shots)
                        {
                            results.Remove(results[i]);
                        }
                    }
                }
            }
            IEnumerable<Animal> Results = results.Distinct().ToList();
            Console.WriteLine("\nSEARCH RESULTS: \n");
            if(Results.Count().Equals(0))
            {
                Console.WriteLine("> No Matches Found.\n\n");
            }
            else
            {
                foreach (var result in Results)
                {
                    Console.WriteLine("> ID: " + result.ID);
                    Console.WriteLine("> Species: " + result.Species);
                    Console.WriteLine("> Name: " + result.Name);
                    Console.WriteLine("> Gender: " + result.Gender);
                    Console.WriteLine("> Age: " + result.Age);
                    Console.WriteLine("> Breed: " + result.Breed);
                    Console.WriteLine("> Adult Size: " + result.Size);
                    Console.WriteLine("> Personality Type: " + result.Personality_Type);
                    Console.WriteLine("> Special-Needs: " + result.Special_Needs);
                    Console.WriteLine("> Food Requirements: " + result.Food_Requirments);
                    Console.WriteLine("> Spayed/Neutered: " + result.Spayed_or_Neutered);
                    Console.WriteLine("> Recieved Shots: " + result.Recieved_Shots);
                    Console.WriteLine("> Adoption Price: " + result.Adoption_Price);
                    Console.WriteLine("> Category: " + result.Category + "\n\n");
                }
            }
            Console.WriteLine("Press [ENTER] to continue....");
            Console.ReadKey();
            Console.Clear();
            UI.Menu();
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
            database.Animals.InsertOnSubmit(animal);
            try
            {
                database.SubmitChanges();
                Console.WriteLine($"\n! {animal.Name} has successfully been added as a new guest !");
            }catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Error: A problem occured while saving {animal.Name} to the database.");
            }
            finally
            {
                Console.WriteLine("Hit [ENTER] to continue.....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
        }

        public static void AddAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Adopter adopter = UI.GetNewAdopterInfo();
            database.Adopters.InsertOnSubmit(adopter);
            try
            {
                database.SubmitChanges();
                Console.WriteLine($"\n! {adopter.First_Name} {adopter.Last_Name} has successfully been added as an adopter !");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Error: A problem occured while saving {adopter.First_Name} {adopter.Last_Name} to the database.");
            }
            finally
            {
                Console.WriteLine("Hit [ENTER] to continue.....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
        }

        public static void RemoveAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void RemoveAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void GiveShots()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine("Do you know the animal's ID?");
            string answer = Console.ReadLine();
            if(answer == "no")
            {
                Console.WriteLine("Here are all the animals who have not recieved shots: ");
                var matches = database.Animals.Where(s => s.Recieved_Shots == false).OrderBy(n => n.ID);
                if(matches == null)
                {
                    Console.WriteLine("All animals are currently up-to-date on vaccinations.\n");
                }else
                {
                    foreach(var match in matches)
                    {
                        Console.WriteLine("> " + match + "\n");
                    }
                }
                Console.WriteLine("Hit [ENTER] to continue.....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
            else if(answer == "yes")
            {
                Console.WriteLine("Enter the animals ID: ");
                int response = int.Parse(Console.ReadLine());
                var match = new List<Animal>();
                foreach(var animal in database.Animals)
                {
                    if(animal.ID == response)
                    {
                        animal.Recieved_Shots = true;
                        match.Add(animal);
                        SaveChanges();
                        Console.WriteLine($"{animal.Name} successfully recieved shots");
                        break;
                    }
                }
                if(match.Count == 0)
                {
                    Console.WriteLine("\nNo current animals in the Humane Society match that ID.");
                }
                Console.WriteLine("\nHit [ENTER] to continue.....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
            else
            {
                Console.WriteLine("Invalid input. Only enter [yes] or [no].");
                Thread.Sleep(1500);
                Console.Clear();
                GiveShots();
            }
        }
    }
}
