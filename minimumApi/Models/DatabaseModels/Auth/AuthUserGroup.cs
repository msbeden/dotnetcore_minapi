using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthUserGroup : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AuthUserGroupId { get; set; }
        [ForeignKey("User")]
        public int AuthUserId { get; set; }
        public virtual AuthUser User { get; set; }
        [ForeignKey("Group")]
        public int AuthGroupId { get; set; }
        public virtual AuthGroup Group { get; set; }
    }
}
