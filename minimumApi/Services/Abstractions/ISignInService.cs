using minimumApi.Models;
using minimumApi.Models.ViewModels.Login;

namespace minimumApi.Services.Abstractions
{
    public interface ISignInService
    {
        ServiceResponse<SignInResponseViewModel> ActionSignIn(SignInRequestViewModel authObject);
        ServiceResponse<bool> ActionSignUp(SignUpViewModel userObject);
        ServiceResponse<bool> ActionForgottenPassword(ForgottenPasswordViewModel authObject);
        ServiceResponse<bool> ActionAssignUserGroup(AssignUserGroupRequestViewModel userObject);
    }
}
