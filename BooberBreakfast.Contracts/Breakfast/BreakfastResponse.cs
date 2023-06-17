using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooberBreakfast.Contracts.Breakfast
{
    public record BreakfastResponse(
        Guid Id,
    string Name, 
    string Description, 
    DateTime StartDateTime, 
    DateTime LastModifiedDateTime, 
    List<string> Savory, 
    List<string> Sweet);
        
        
        
 }
