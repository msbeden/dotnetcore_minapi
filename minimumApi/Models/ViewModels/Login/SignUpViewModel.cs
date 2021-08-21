﻿using minimumApi.Models.Abstractions;
using System.Collections.Generic;

namespace minimumApi.Models.ViewModels.Login
{
    public class SignUpViewModel : IViewModel
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Gsm { get; set; }
        public IEnumerable<int> GroupIds { get; set; }
        public IEnumerable<KeyValuePair<int, int>> Features { get; set; }
    }
}
