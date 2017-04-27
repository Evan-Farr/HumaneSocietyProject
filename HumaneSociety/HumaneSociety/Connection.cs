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
        }

        public static void SearchByAnimalName()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void SearchByCharacteristics()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void SearchByAdopterName()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void AddAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

        }

        public static void AddAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();

        }

        public static void RemoveAnimal()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }

        public static void RemoveAdopter()
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
        }
    }
}
