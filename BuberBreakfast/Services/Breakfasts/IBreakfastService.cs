using BooberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;
using ErrorOr;

namespace BuberBreakfast.Services.Breakfasts
{
    public interface IBreakfastService
    {
        public void CreateBreakfast(Breakfast breakfast);

        public ErrorOr<Breakfast> GetBreakfast(Guid id);
        public int UpdateBreakfast(Guid id, Breakfast breakfast);
        void DeleteBreakfast(Guid id);
    }
}
