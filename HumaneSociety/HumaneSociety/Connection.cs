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
    }
}
