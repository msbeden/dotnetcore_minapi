using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthGroupPermission : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AuthGroupPermissionId { get; set; }
        [ForeignKey("Group")]
        public int AuthGroupId { get; set; }
        public virtual AuthGroup Group { get; set; }
        [ForeignKey("Permission")]
        public int AuthPermissionId { get; set; }
        public virtual AuthPermission Permission { get; set; }
    }
}
