using BuberBreakfast.Models;

namespace BuberBreakfast.Services.Breakfasts
{
    public class BreakfastService : IBreakfastService
    {
        private static readonly Dictionary<Guid, Breakfast> _breakfasts = new Dictionary<Guid, Breakfast>();
        public void CreateBreakfast(Breakfast breakfast)
        {
           
            _breakfasts.Add(breakfast.Id, breakfast);

        }

        public Breakfast GetBreakfast(Guid id)
        {
            if(id.Equals(Guid.Empty))
            {
                return new Breakfast();
            }

            else if (_breakfasts.ContainsKey(id))
            {
                return _breakfasts[id];
            }

            throw new KeyNotFoundException($"Breakfast with ID {id} not found.");


        }

        public int UpdateBreakfast(Guid id, Breakfast breakfast)
        {
            if (_breakfasts.ContainsKey(id))
            {
                _breakfasts[id] = breakfast;
                return 1;
            }
            else
            {
                _breakfasts.Add(id, breakfast);
                return 0;
            }
        }

        public void DeleteBreakfast(Guid id)
        {
            if (_breakfasts.ContainsKey(id))
            {
                _breakfasts.Remove(id);
            }
        }
    }
}
