using BooberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        public void CreateBreakfast(Breakfast breakfast);

        public Breakfast GetBreakfast(Guid id);
        public int UpdateBreakfast(Guid id, Breakfast breakfast);
        void DeleteBreakfast(Guid id);
    }
}
