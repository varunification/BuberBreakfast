using BooberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        public void CreateBreakfast(Breakfast breakfast);

        Breakfast GetBreakfast(Guid id);


    }
}
