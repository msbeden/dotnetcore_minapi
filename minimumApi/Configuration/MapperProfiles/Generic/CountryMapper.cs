using AutoMapper;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class CountryMapper : Profile
    {
        public CountryMapper()
        {
            CreateMap<CountryViewModel, Country>();
            CreateMap<Country, CountryViewModel>();
        }
    }
}
