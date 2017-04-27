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
                    Update.AddAnimal();
                    break;
                case "4":
                    Update.AddAdopter();
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
    }
}
