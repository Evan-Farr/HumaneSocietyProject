using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumaneSociety
{
    public interface INeed
    {
        bool SpecialNeeds { get; set; }
        string FoodRequirements { get; set; }
    }
}
