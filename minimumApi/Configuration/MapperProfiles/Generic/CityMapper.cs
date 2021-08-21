using AutoMapper;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class CityMapper : Profile
    {
        public CityMapper()
        {
            CreateMap<CityViewModel, City>();
            CreateMap<City, CityViewModel>();
        }
    }
}
