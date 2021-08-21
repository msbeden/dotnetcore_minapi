using AutoMapper;
using minimumApi.Models.DatabaseModels.Auth;
using minimumApi.Models.ViewModels.Login;

namespace minimumApi.Configuration.MapperProfiles
{
    public class SignInMapper : Profile
    {
        public SignInMapper()
        {
            CreateMap<SignInRequestViewModel, AuthUser>();
            CreateMap<AuthUser, SignInRequestViewModel>();

            CreateMap<SignInResponseViewModel, AuthUser>()
                .ForMember(x => x.AuthUserId, opt => opt.MapFrom(x => x.UserId));
            CreateMap<AuthUser, SignInResponseViewModel>()
                .ForMember(x => x.UserId, opt => opt.MapFrom(x => x.AuthUserId));

            CreateMap<SignUpViewModel, AuthUser>();
            CreateMap<AuthUser, SignUpViewModel>();

            CreateMap<ForgottenPasswordViewModel, AuthUser>();
            CreateMap<AuthUser, ForgottenPasswordViewModel>();
        }
    }
}
