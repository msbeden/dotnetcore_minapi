using minimumApi.Models.Abstractions;
using System.Collections.Generic;

namespace minimumApi.Models.ViewModels.Login
{
    public class SignInResponseViewModel : IViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Gsm { get; set; }
        public string Token { get; set; }
        public IEnumerable<AuthGroupViewModel> Groups { get; set; }
        public IEnumerable<AuthFeatureViewModel> Features { get; set; }
    }
}
