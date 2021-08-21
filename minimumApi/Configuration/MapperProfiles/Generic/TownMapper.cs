using AutoMapper;
using minimumApi.Models.DatabaseModels;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class TownMapper : Profile
    {
        public TownMapper()
        {
            CreateMap<TownViewModel, Town>();
            CreateMap<Town, TownViewModel>();
        }
    }
}
