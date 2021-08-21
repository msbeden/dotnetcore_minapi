using AutoMapper;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class AuthPermissionMapper : Profile
    {
        public AuthPermissionMapper()
        {
            CreateMap<AuthPermissionViewModel, AuthPermission>();
            CreateMap<AuthPermission, AuthPermissionViewModel>();
        }
    }
}
