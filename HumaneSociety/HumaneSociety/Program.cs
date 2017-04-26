using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    class Program
    {
        static void Main(string[] args)
        {
            HumaneSociety hs = new HumaneSociety();
            Animal puppy = new Dog(hs.GenerateUniqueID(), "Rodger", "male", "8 months", "Greyhound", "Active", false,
                "One scoop, twice per day(morning/late afternoon)", true, true, 345);
            hs.IntakeAnimal(puppy);
        }
    }
}
