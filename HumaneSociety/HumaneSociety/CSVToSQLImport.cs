using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public static class CSVToSQLImport
    {
        public static List<string[]> ReadCSV(string file)
        {
            var dataImport = File.ReadLines(file).Select(l => l.Split(',')).Select(x => x).ToList();
            return dataImport;
        }

        public static void ImportCSV(string file)
        {
            HumaneSocietyDataContext database = new HumaneSocietyDataContext();
            var imported = ReadCSV(file);
            foreach(var data in imported)
            {
                Animal animal = new Animal();
                animal.Species = data[0];
                animal.Name = data[1];
                animal.Gender = data[2];
                animal.Age = int.Parse(data[3]);
                animal.Breed = data[4];
                animal.Size = data[5];
                animal.Personality_Type = data[6];
                animal.Special_Needs = bool.Parse(data[7]);
                animal.Food_Requirments = data[8];
                animal.Spayed_or_Neutered = bool.Parse(data[9]);
                animal.Recieved_Shots = bool.Parse(data[10]);
                animal.Adoption_Price = double.Parse(data[11]);
                animal.Category = data[12];

                database.Animals.InsertOnSubmit(animal);
            }
            database.SubmitChanges();
            Console.WriteLine("File successfully added.\n\n");
            Console.WriteLine("Press [ENTER] to continue....");
            Console.ReadKey();
            Console.Clear();
            UI.Menu();
        }

        //    SqlBulkCopy objBulk = new SqlBulkCopy(connection);
        //    objBulk.DestinationTableName = "Animal";
        //    objBulk.ColumnMappings.Add("Species", "Species");
        //    objBulk.ColumnMappings.Add("Name", "Name");
        //    objBulk.ColumnMappings.Add("Gender", "Gender");
        //    objBulk.ColumnMappings.Add("Age", "Age");
        //    objBulk.ColumnMappings.Add("Breed", "Breed");
        //    objBulk.ColumnMappings.Add("Size", "Size");
        //    objBulk.ColumnMappings.Add("Personality_Type", "Personality_Type");
        //    objBulk.ColumnMappings.Add("Special_Needs", "Special_Needs");
        //    objBulk.ColumnMappings.Add("Food_Requirements", "Food_Requirements");
        //    objBulk.ColumnMappings.Add("Spayed_Or_Neutered", "Spayed_Or_Neutered");
        //    objBulk.ColumnMappings.Add("Recieved_Shots", "Recieved_Shots");
        //    objBulk.ColumnMappings.Add("Adoption_Price", "Adoption_Price");
        //    objBulk.ColumnMappings.Add("Category", "Category");
    }
}
