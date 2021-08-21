using minimumApi.Models.Abstractions;

namespace minimumApi.Models.ViewModels
{
    public class AuthUserViewModel : IViewModel
    {
        public int AuthUserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Gsm { get; set; }
        public bool IsEnabled { get; set; }
    }
}
