using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthUser : BaseEntity, IDbDeletable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthUserId { get; set; }
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Password { get; set; }
        public string PasswordHash { get; set; }
        public string EMail { get; set; }
        public string Gsm { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
    }
}
