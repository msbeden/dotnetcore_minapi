using AutoMapper;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class AuthUserMapper : Profile
    {
        public AuthUserMapper()
        {
            CreateMap<AuthUserViewModel, AuthUser>();
            CreateMap<AuthUser, AuthUserViewModel>();
        }
    }
}
