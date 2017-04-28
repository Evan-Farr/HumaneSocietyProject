using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class UI
    {
       public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("              MAIN MENU             ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Search for animal");
            Console.WriteLine("2) Search for adopter");
            Console.WriteLine("3) Add new animal");
            Console.WriteLine("4) Add new adopter");
            Console.WriteLine("5) Update existing animal (must know ID)");
            Console.WriteLine("6) Remove adopted animal");
            Console.WriteLine("7) Save changes");
            Console.WriteLine("8) Exit \n");
            Console.WriteLine("===> Input number, then hit [ENTER]:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    AnimalSubMenu1();
                    break;
                case "2":
                    Console.Clear();
                    AdopterSubMenu1();
                    break;
                case "3":
                    Console.Clear();
                    Connection.AddAnimal();
                    break;
                case "4":
                    Console.Clear();
                    Connection.AddAdopter();
                    break;
                case "5":
                    Console.Clear();
                    UI.UpdateAnimalMenu();
                    break;
                case "6":
                    Console.Clear();
                    Connection.RemoveAnimal();
                    break;
                case "7":
                    Connection.SaveChanges();
                    break;
                case "8":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid.");
                    Thread.Sleep(2000);
                    Console.Clear();
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
                    Console.Clear();
                    Connection.SearchBySpecies();
                    break;
                case "2":
                    Console.Clear();
                    Connection.SearchByAnimalName();
                    break;
                case "3":
                    Console.Clear();
                    Connection.SearchByCharacteristics();
                    break;
                case "4":
                    Console.Clear();
                    Menu();
                    break;
                case "5":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid. Enter only the number.");
                    Thread.Sleep(2000);
                    Console.Clear();
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
                    Console.Clear();
                    Connection.SearchByAdopterName();
                    break;
                case "2":
                    Console.Clear();
                    Menu();
                    break;
                case "3":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid. Enter only the number.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    AdopterSubMenu1();
                    break;
            }
        }

        public static void UpdateAnimalMenu()
        {
            Console.WriteLine();
            Console.WriteLine("------------------------------------");
            Console.WriteLine("         UPDATE ANIMAL MENU         ");
            Console.WriteLine("------------------------------------");
            Console.WriteLine("1) Name");
            Console.WriteLine("2) Gender");
            Console.WriteLine("3) Age");
            Console.WriteLine("4) Breed");
            Console.WriteLine("5) Size");
            Console.WriteLine("6) Personality Type");
            Console.WriteLine("7) Special Needs");
            Console.WriteLine("8) Food Requirements");
            Console.WriteLine("9) Spayed/Neutered");
            Console.WriteLine("10) Shots/Vaccinations");
            Console.WriteLine("11) Adoption Price");
            Console.WriteLine("12) Category");
            Console.WriteLine("13) Main Menu");
            Console.WriteLine("14) Exit \n");
            Console.WriteLine("===> Input number, then hit [ENTER]:");
            string selection = Console.ReadLine();
            switch (selection)
            {
                case "1":
                    Console.Clear();
                    Connection.UpdateAnimal(1);
                    break;
                case "2":
                    Console.Clear();
                    Connection.UpdateAnimal(2);
                    break;
                case "3":
                    Console.Clear();
                    Connection.UpdateAnimal(3);
                    break;
                case "4":
                    Console.Clear();
                    Connection.UpdateAnimal(4);
                    break;
                case "5":
                    Console.Clear();
                    Connection.UpdateAnimal(5);
                    break;
                case "6":
                    Console.Clear();
                    Connection.UpdateAnimal(6);
                    break;
                case "7":
                    Console.Clear();
                    Connection.UpdateAnimal(7);
                    break;
                case "8":
                    Console.Clear();
                    Connection.UpdateAnimal(8);
                    break;
                case "9":
                    Console.Clear();
                    Connection.UpdateAnimal(9);
                    break;
                case "10":
                    Console.Clear();
                    Connection.GiveShots();
                    break;
                case "11":
                    Console.Clear();
                    Connection.UpdateAnimal(11);
                    break;
                case "12":
                    Console.Clear();
                    Connection.UpdateAnimal(12);
                    break;
                case "13":
                    Console.Clear();
                    Menu();
                    break;
                case "14":
                    Console.Clear();
                    break;
                default:
                    Console.WriteLine("Input not valid. Enter only the number.");
                    Thread.Sleep(2000);
                    Console.Clear();
                    AnimalSubMenu1();
                    break;
            }
        }

        public static Animal GetAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            Animal animal = new Animal();
            Console.WriteLine("\nEnter animal's ID: ");
            try
            {
                int choice;
                bool isNumber = int.TryParse(Console.ReadLine(), out choice);
                foreach(var a in database.Animals)
                {
                    if (a.ID == choice)
                    {
                        animal = a;
                        break;
                    }
                }
            }catch
            {
                Console.WriteLine("You did not enter a valid ID for a current animal at the Humane Society.");
                Console.WriteLine("Hit [ENTER] to return to the Main Menu....");
                Console.ReadKey();
                Console.Clear();
                Menu();
            }
            Console.Clear();
            return animal;
        }

        public static Animal GetKnownCharacteristics()
        {
            Animal animal = new Animal();
            Console.WriteLine("\nFor each characteristic, enter search term.");
            Console.WriteLine("*If you don't know a certain characteristic, leave input blank and press [ENTER].");
            Console.WriteLine("1. Species: ");
            animal.Species = Console.ReadLine().ToLower();
            Console.WriteLine("2. Animal's Name: ");
            animal.Name = Console.ReadLine().ToLower();
            Console.WriteLine("3. Gender: ");
            animal.Gender = Console.ReadLine().ToLower();
            Console.WriteLine("4. Age: ");
            int result;
            bool isNumber = int.TryParse(Console.ReadLine(), out result);
            animal.Age = result;
            Console.WriteLine("5. Breed: ");
            animal.Breed = Console.ReadLine().ToLower();
            Console.WriteLine("6. Size as Adult: ");
            animal.Size = Console.ReadLine().ToLower();
            Console.WriteLine("7. Personality Type: ");
            animal.Personality_Type = Console.ReadLine().ToLower();
            Console.WriteLine("8. Has Special Needs (enter 'yes' or 'no'): ");
            string input = Console.ReadLine().ToLower();
            if(input == "yes")
            {
                animal.Special_Needs = true;
            }else if(input == "no") 
            {
                animal.Special_Needs = false;
            }
            Console.WriteLine("9. Received Shots (enter 'yes' or 'no'): ");
            string input2 = Console.ReadLine().ToLower();
            if (input2 == "yes")
            {
                animal.Recieved_Shots = true;
            }
            else if (input2 == "no")
            {
                animal.Recieved_Shots = false;
            }
            Console.Clear();
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
            Console.Clear();
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
            adopter.Phone = Console.ReadLine();
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
            Console.Clear();
            return adopter;
        }
    }
}
