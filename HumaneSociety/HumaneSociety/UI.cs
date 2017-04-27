using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class UI
    {
       public static void Menu()
        {
            Console.WriteLine("------------------------------------");
            Console.WriteLine("              MAIN MENU             ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Search for animal");
            Console.WriteLine("2) Search for adopter");
            Console.WriteLine("3) Add new animal");
            Console.WriteLine("4) Add new adopter");
            Console.WriteLine("5) Save changes");
            Console.WriteLine("6) Exit \n");
            Console.WriteLine("===> Input number, then hit [ENTER]:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    AnimalSubMenu1();
                    break;
                case "2":
                    AdopterSubMenu1();
                    break;
                case "3":
                    Connection.AddAnimal();
                    break;
                case "4":
                    Connection.AddAdopter();
                    break;
                case "5":
                    Connection.SaveChanges();
                    break;
                case "6":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid. Enter only the number.");
                    Menu();
                    break;
            }
        }

        public static void AnimalSubMenu1()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("            ANIMAL MENU             ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Search by species");
            Console.WriteLine("2) Search by name");
            Console.WriteLine("3) Search by other characteristics");
            Console.WriteLine("4) Main Menu");
            Console.WriteLine("5) Exit \n");
            Console.WriteLine("===> Input number, then hit [ENTER]:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Connection.SearchBySpecies();
                    break;
                case "2":
                    Connection.SearchByAnimalName();
                    break;
                case "3":
                    Connection.SearchByCharacteristics();
                    break;
                case "4":
                    Menu();
                    break;
                case "5":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid. Enter only the number.");
                    AnimalSubMenu1();
                    break;
            }
        }

        public static void AdopterSubMenu1()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("            ADOPTER MENU            ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Search by name");
            Console.WriteLine("2) Main Menu");
            Console.WriteLine("3) Exit \n");
            Console.WriteLine("===> Input number, then hit [ENTER]:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Connection.SearchByAdopterName();
                    break;
                case "2":
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid. Enter only the number.");
                    AdopterSubMenu1();
                    break;
            }
        }

        public static Animal GetKnownCharacteristics()
        {
            Animal animal = new Animal();
            Console.WriteLine("\nFor each characteristic, enter search term.");
            Console.WriteLine("*If you don't know a certain characteristic, enter 'NA' as an answer.");
            Console.WriteLine("1. Species: ");
            animal.Species = Console.ReadLine().ToLower();
            Console.WriteLine("2. Animal's Name: ");
            animal.Name = Console.ReadLine().ToLower();
            Console.WriteLine("3. Gender: ");
            animal.Gender = Console.ReadLine().ToLower();
            Console.WriteLine("4. Age: ");
            animal.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("5. Breed: ");
            animal.Breed = Console.ReadLine().ToLower();
            Console.WriteLine("6. Size as Adult: ");
            animal.Size = Console.ReadLine().ToLower();
            Console.WriteLine("7. Personality Type: ");
            animal.Personality_Type = Console.ReadLine().ToLower();
            Console.WriteLine("8. Has Special Needs (enter 'true' or 'false'): ");
            animal.Special_Needs = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("9. Received Shots (enter 'true' or 'false'): ");
            animal.Recieved_Shots = bool.Parse(Console.ReadLine().ToLower());
            return animal;
        }

        public static Animal GetNewAnimalInfo()
        {
            Animal animal = new Animal();
            Console.WriteLine("\nFor each characteristic, enter information.");
            Console.WriteLine("*If you don't know a certain characteristic, enter 'NA' as an answer.");
            Console.WriteLine("1. Species: ");
            animal.Species = Console.ReadLine().ToLower();
            Console.WriteLine("2. Animal's Name: ");
            animal.Name = Console.ReadLine().ToLower();
            Console.WriteLine("3. Gender: ");
            animal.Gender = Console.ReadLine().ToLower();
            Console.WriteLine("4. Age (if less than 1, input '-1': ");
            animal.Age = int.Parse(Console.ReadLine());
            Console.WriteLine("5. Breed: ");
            animal.Breed = Console.ReadLine().ToLower();
            Console.WriteLine("6. Size as Adult: ");
            animal.Size = Console.ReadLine().ToLower();
            Console.WriteLine("7. Personality Type: ");
            animal.Personality_Type = Console.ReadLine().ToLower();
            Console.WriteLine("8. Has Special Needs (enter 'true' or 'false'): ");
            animal.Special_Needs = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("9. Food Requirements: ");
            animal.Food_Requirments = Console.ReadLine().ToLower();
            Console.WriteLine("10. Is Spayed or Neutered (enter 'true' or 'false'): ");
            animal.Spayed_or_Neutered = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("11. Received Shots (enter 'true' or 'false'): ");
            animal.Recieved_Shots = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("12. Animal Category (Options = Dog/Cat/Small-Animal): ");
            animal.Category = Console.ReadLine().ToLower();
            Console.WriteLine("12. Adoption Price: ");
            animal.Adoption_Price = double.Parse(Console.ReadLine());
            return animal;
        }

        public static Adopter GetNewAdopterInfo()
        {
            Adopter adopter = new Adopter();
            Console.WriteLine("\nFor each characteristic, enter information.");
            Console.WriteLine("*If you don't know a certain characteristic, enter 'NA' as an answer.");
            Console.WriteLine("1. First Name: ");
            adopter.First_Name = Console.ReadLine().ToLower();
            Console.WriteLine("2. Middle Initial: ");
            adopter.Middle_Initial = Console.ReadLine().ToLower();
            Console.WriteLine("3. Last Name: ");
            adopter.Last_Name = Console.ReadLine().ToLower();
            Console.WriteLine("4. Street Address: ");
            adopter.Street_Address = Console.ReadLine();
            Console.WriteLine("5. Email: ");
            adopter.Email = Console.ReadLine().ToLower();
            Console.WriteLine("6. Phone Number: ");
            adopter.Phone = int.Parse(Console.ReadLine());
            Console.WriteLine("7. Personality Profile: ");
            adopter.Personality_Profile = Console.ReadLine().ToLower();
            Console.WriteLine("8. Has Small Children (enter 'true' or 'false'): ");
            adopter.Small_Children = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("10. Has other Animals (enter 'true' or 'false'): ");
            adopter.Animals = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("11. Number of other Animals: ");
            adopter.Number_Of_Animals = int.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("12. Type of other Animals: ");
            adopter.Type_Of_Animals = Console.ReadLine().ToLower();
            Console.WriteLine("12. ID of animal interested in adopting: ");
            adopter.Animals_Interested_In_Adopting = int.Parse(Console.ReadLine().ToLower());
            return adopter;
        }
    }
}
