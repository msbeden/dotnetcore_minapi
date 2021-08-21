using AutoMapper;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels;

namespace minimumApi.Configuration.MapperProfiles
{
    public class AuthFeatureMapper : Profile
    {
        public AuthFeatureMapper()
        {
            CreateMap<AuthFeatureViewModel, AuthFeature>();
            CreateMap<AuthFeature, AuthFeatureViewModel>();
        }
    }
}
