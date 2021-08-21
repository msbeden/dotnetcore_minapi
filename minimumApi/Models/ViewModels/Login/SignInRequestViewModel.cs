using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels.Login
{
    public class SignInRequestViewModel : IViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
