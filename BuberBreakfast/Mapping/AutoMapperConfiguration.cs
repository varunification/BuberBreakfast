using AutoMapper;
using BooberBreakfast.Contracts.Breakfast;
using BuberBreakfast.Models;

namespace BuberBreakfast.Mapping
{
    public static class AutoMapperConfiguration
    {
        public static IMapper Configure()
        {
            var mapperConfig = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Breakfast, BreakfastResponse>();
            });

            IMapper mapper = mapperConfig.CreateMapper();
            return mapper;
        }
    }


}
