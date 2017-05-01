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
            var imported = ReadCSV(file);
            foreach(var data in imported)
            {

            }
        }
    }
}
