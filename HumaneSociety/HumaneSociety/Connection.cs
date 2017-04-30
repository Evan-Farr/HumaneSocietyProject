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
            if (matches != null)
            {
                Console.WriteLine("\nSEARCH RESULTS: \n");
                foreach (var match in matches)
                {
                    Console.WriteLine("> ID: " + match.ID);
                    Console.WriteLine("> First Name: " + match.First_Name);
                    Console.WriteLine("> Middle Initial: " + match.Middle_Initial);
                    Console.WriteLine("> Last Name: " + match.Last_Name);
                    Console.WriteLine("> Street Address: " + match.Street_Address);
                    Console.WriteLine("> Email: " + match.Email);
                    Console.WriteLine("> Phone Number: " + match.Phone);
                    Console.WriteLine("> Billing Info: " + match.Billing);
                    Console.WriteLine("> Personality Profile: " + match.Personality_Profile);
                    Console.WriteLine("> Has small children: " + match.Small_Children);
                    Console.WriteLine("> Has other animals: " + match.Animals);
                    Console.WriteLine("> Number of other animals: " + match.Number_Of_Animals);
                    Console.WriteLine("> Type of other animals: " + match.Type_Of_Animals);
                    Console.WriteLine("> ID of animal interested in adopting: " + match.Animals_Interested_In_Adopting);
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

        public static void AddAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal animal = UI.GetNewAnimalInfo();
            database.Animals.InsertOnSubmit(animal);
            try
            {
                database.SubmitChanges();
                Console.WriteLine($"\n! {animal.Name} has successfully been added as a new guest !\n\n");
                Console.WriteLine($"Now let's give {animal.Name} a room to stay in.\n");
                FindAvailableRoom();
                AddAnimalToRoom(animal);
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"Error: A problem occured while saving {animal.Name} to the database.\n\n");
            }
            finally
            {
                Console.WriteLine("Hit [ENTER] to return to Main Menu.");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
        }

        public static void FindAvailableRoom()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var availableRooms = database.Rooms.Where(r => r.Is_Available == true).OrderBy(o => o.ID).Select(s => s).ToList();
            Console.WriteLine("All Available Rooms: \n");
            foreach(var room in availableRooms)
            {
                Console.WriteLine("> Room ID: " + room.ID);
                Console.WriteLine("  Room Number: " + room.Room_Number + "\n");
            }
            Console.WriteLine();
        }

        public static void AddAnimalToRoom(Animal animal)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine($"Enter the room ID {animal.Name} will be moving into: ");
            int choice;
            bool isNumber = int.TryParse(Console.ReadLine(), out choice);
            var check = database.Rooms.Where(r => r.ID == choice).Select(s => s).ToList();
            foreach(var room in check)
            {
                if(room.Is_Available == false)
                {
                    Console.WriteLine("That room is not available.\n");
                    AddAnimalToRoom(animal);
                }
                else
                {
                    room.Current_Animal = animal.ID;
                    try
                    {
                        database.SubmitChanges();
                        Console.WriteLine($"{animal.Name} successfully added to room number {room.Room_Number}!\n");
                    }catch
                    {
                        Console.WriteLine($"Error: A problem occured while saving {animal.Name} to the {room.Room_Number}.\n\n");
                        AddAnimalToRoom(animal);
                    }
                }
            }
        }

        public static void FindAnimalsRoom()
        {

        }

        public static void AddAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Adopter adopter = UI.GetNewAdopterInfo();
            database.Adopters.InsertOnSubmit(adopter);
            try
            {
                database.SubmitChanges();
                Console.WriteLine($"\n! {adopter.First_Name} {adopter.Last_Name} has successfully been added as an adopter !\n\n");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Console.WriteLine($"\nError: A problem occured while saving {adopter.First_Name} {adopter.Last_Name} to the database.\n\n");
            }
            finally
            {
                Console.WriteLine("Hit [ENTER] to continue....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
        }

        public static void RemoveAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal tempanimal = UI.GetAnimal();
            foreach(var animal in database.Animals)
            {
                if(animal.ID == tempanimal.ID)
                {
                    Console.WriteLine("\nPlease confirm this is the animal being adopted and should be removed from database.\n");
                    Console.WriteLine("> ID: " + animal.ID);
                    Console.WriteLine("> Species: " + animal.Species);
                    Console.WriteLine("> Name: " + animal.Name);
                    Console.WriteLine("> Gender: " + animal.Gender);
                    Console.WriteLine("> Age: " + animal.Age);
                    Console.WriteLine("> Breed: " + animal.Breed);
                    Console.WriteLine("> Adult Size: " + animal.Size);
                    Console.WriteLine("> Personality Type: " + animal.Personality_Type);
                    Console.WriteLine("> Special-Needs: " + animal.Special_Needs);
                    Console.WriteLine("> Food Requirements: " + animal.Food_Requirments);
                    Console.WriteLine("> Spayed/Neutered: " + animal.Spayed_or_Neutered);
                    Console.WriteLine("> Recieved Shots: " + animal.Recieved_Shots);
                    Console.WriteLine("> Adoption Price: " + animal.Adoption_Price);
                    Console.WriteLine("> Category: " + animal.Category + "\n\n");
                    Console.WriteLine("If this is the correct animal enter [yes], if not enter [no].");
                    string decision = Console.ReadLine().ToLower();
                    Console.Clear();
                    if (decision == "yes")
                    {
                        database.Animals.DeleteOnSubmit(animal);
                        try
                        {
                            database.SubmitChanges();
                            Console.WriteLine($"\n{animal.Name} has successfully been removed.\n\n");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e);
                            Console.WriteLine($"Error: A problem occured while saving {animal.Name} to the database.");
                        }
                        finally
                        {
                            Console.WriteLine("Hit [ENTER] to return to Main Menu");
                            Console.ReadKey();
                            Console.Clear();
                            UI.Menu();
                        }
                    }
                    else if(decision == "no")
                    {
                        Console.WriteLine("Ok. Make sure you know the animal's ID before attempting to make a deletion.\n\n");
                        Console.WriteLine("Hit [ENTER] to return to Main Menu");
                        Console.ReadKey();
                        Console.Clear();
                        UI.Menu();
                    }
                    else
                    {
                        Console.WriteLine("Error: Please enter only [yes] or [no] as a response.");
                        Console.Clear();
                        RemoveAnimal();
                    }
                    break;
                }
            }
        }

        public static void GiveShots()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Console.WriteLine("Do you know the animal's ID? (Enter [yes] or [no])");
            string answer = Console.ReadLine();
            if(answer == "no")
            {
                Console.Clear();
                var noShots = new List<Animal>();
                var check = new List<Animal>();
                var matches = database.Animals.Where(s => s.Recieved_Shots == false).OrderBy(n => n.ID);
                if(matches == null)
                {
                    Console.WriteLine("All animals are currently up-to-date on vaccinations.\n");
                }else
                {
                    Console.WriteLine("\nHere are all the animals who have not recieved shots: \n");
                    foreach (var match in matches)
                    {
                        Console.WriteLine("> ID: " + match.ID + " => Species: " + match.Species + " => Name: " + match.Name + "\n");
                        noShots.Add(match);
                    }
                    Console.WriteLine("\nEnter the animals ID: ");
                    int choice = int.Parse(Console.ReadLine());
                    foreach (var animal in database.Animals)
                    {
                        if (animal.ID == choice)
                        {
                            animal.Recieved_Shots = true;
                            check.Add(animal);
                            SaveChanges();
                            Console.WriteLine($"\n{animal.Name} successfully recieved shots.\n\n");
                            break;
                        }
                    }                    
                    if (check.Count == 0)
                    {
                        Console.WriteLine("\nError: Invalid Input. Make sure you are entering the ID number that matches an animal who");
                        Console.WriteLine("has not recieved shots.\n\n");
                    }
                }
                Console.WriteLine("Hit [ENTER] to continue....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
            else if(answer == "yes")
            {
                Console.Clear();
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
                        Console.WriteLine($"\n{animal.Name} successfully recieved shots.\n\n");
                        break;
                    }
                }
                if(match.Count == 0)
                {
                    Console.WriteLine("\nNo current animals in the Humane Society match that ID.\n\n");
                }
            }
            else
            {
                Console.WriteLine("\nError: Invalid input. Only enter [yes] or [no].");
                Thread.Sleep(1500);
                Console.Clear();
                GiveShots();
            }
            try
            {
                database.SubmitChanges();
            }catch
            {
                Console.WriteLine("An error occured. Changes to the database did not go through.\n\n");
            }finally
            {
                Console.WriteLine("Hit [ENTER] to continue....");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
        }

        public static void UpdateAnimal(int number)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal tempAnimal = UI.GetAnimal();
            foreach(var animal in database.Animals)
            {
                if(animal.ID == tempAnimal.ID)
                {
                    switch (number)
                    {
                        case 1:
                            Console.WriteLine($"What should {animal.Name}'s NAME be changed to?");
                            string name = Console.ReadLine().ToLower();
                            animal.Name = name;
                            break;
                        case 2:
                            Console.WriteLine($"What should {animal.Name}'s GENDER be changed to?");
                            string gender = Console.ReadLine().ToLower();
                            animal.Gender = gender;
                            break;
                        case 3:
                            Console.WriteLine($"What should {animal.Name}'s AGE be changed to?");
                            int age;
                            bool isNumber = int.TryParse(Console.ReadLine(), out age);
                            animal.Age = age;
                            break;
                        case 4:
                            Console.WriteLine($"What should {animal.Name}'s BREED be changed to?");
                            string breed = Console.ReadLine().ToLower();
                            animal.Breed = breed;
                            break;
                        case 5:
                            Console.WriteLine($"What should {animal.Name}'s SIZE be changed to?");
                            string size = Console.ReadLine().ToLower();
                            animal.Size = size;
                            break;
                        case 6:
                            Console.WriteLine($"What should {animal.Name}'s PERSONALITY TYPE be changed to?");
                            string personalityType = Console.ReadLine().ToLower();
                            animal.Personality_Type = personalityType;
                            break;
                        case 7:
                            Console.WriteLine($"What should {animal.Name}'s SPECIAL NEEDS status be changed to?");
                            string specialNeeds = Console.ReadLine().ToLower();
                            if (specialNeeds == "yes")
                            {
                                animal.Special_Needs = true;
                            }
                            else if (specialNeeds == "no")
                            {
                                animal.Special_Needs = false;
                            }
                            break;
                        case 8:
                            Console.WriteLine($"What should {animal.Name}'s FOOD REQUIREMENTS be changed to?");
                            string food = Console.ReadLine().ToLower();
                            animal.Food_Requirments = food;
                            break;
                        case 9:
                            Console.WriteLine($"What should {animal.Name}'s SPAYED/NEUTERED status be changed to?");
                            string spayNeuter = Console.ReadLine().ToLower();
                            if (spayNeuter == "yes")
                            {
                                animal.Spayed_or_Neutered = true;
                            }
                            else if (spayNeuter == "no")
                            {
                                animal.Spayed_or_Neutered = false;
                            }
                            break;
                        case 11:
                            Console.WriteLine($"What should {animal.Name}'s ADPTION PRICE be changed to?");
                            double price;
                            bool isDouble = double.TryParse(Console.ReadLine(), out price);
                            animal.Adoption_Price = price;
                            break;
                        case 12:
                            Console.WriteLine($"What should {animal.Name}'s CATEGORY be changed to?");
                            string category = Console.ReadLine().ToLower();
                            animal.Category = category;
                            break;
                    }
                    break;
                }
            }
            try
            {
                database.SubmitChanges();
                SaveChanges();
                Console.WriteLine("\n\n> Update Successful.\n\n");
            }
            catch
            {
                Console.WriteLine("An error occured. Changes to the database did not go through.\n\n");
            }finally
            {
                Console.WriteLine("Hit [ENTER] to return to Main Menu.");
                Console.ReadKey();
                Console.Clear();
                UI.Menu();
            }
        }
    }
}
