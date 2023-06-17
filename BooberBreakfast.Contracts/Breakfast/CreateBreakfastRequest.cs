using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooberBreakfast.Contracts.Breakfast
{
    //the return type is record
    public record CreateBreakfastRequest(string Name, string Description, DateTime StartDateTime, DateTime EndDateTime, List<string> Savory, List<string> Sweet)
    {
        
    }
}
