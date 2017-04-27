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
            Console.WriteLine("For each characteristic, enter search term.");
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
            Console.WriteLine("6. Size: ");
            animal.Size = Console.ReadLine().ToLower();
            Console.WriteLine("7. Personality Type: ");
            animal.Personality_Type = Console.ReadLine().ToLower();
            Console.WriteLine("5. Has Special Needs (enter 'true' or 'false'): ");
            animal.Special_Needs = bool.Parse(Console.ReadLine().ToLower());
            Console.WriteLine("7. Received Shots (enter 'true' or 'false'): ");
            animal.Recieved_Shots = bool.Parse(Console.ReadLine().ToLower());
            return animal;
        }
    }
}
