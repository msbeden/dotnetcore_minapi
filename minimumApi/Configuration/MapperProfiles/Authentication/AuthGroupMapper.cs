using AutoMapper;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class AuthGroupMapper : Profile
    {
        public AuthGroupMapper()
        {
            CreateMap<AuthGroupViewModel, AuthGroup>();
            CreateMap<AuthGroup, AuthGroupViewModel>();
        }
    }
}
