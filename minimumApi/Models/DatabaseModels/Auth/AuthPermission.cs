using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthPermission : BaseEntity, IDbDeletable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthPermissionId { get; set; }
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
    }
}
