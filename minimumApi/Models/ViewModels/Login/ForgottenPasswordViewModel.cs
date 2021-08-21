using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels.Login
{
    public class ForgottenPasswordViewModel : IViewModel
    {
        public string Username { get; set; }
        public string EMail { get; set; }
    }
}
