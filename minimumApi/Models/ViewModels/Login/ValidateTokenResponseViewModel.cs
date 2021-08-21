using minimumApi.Models.Abstractions;
using System;

namespace minimumApi.Models.ViewModels.Login
{
    public class ValidateTokenResponseViewModel : IViewModel
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Gsm { get; set; }
        public DateTime ExpiredDate { get; set; }
    }
}
