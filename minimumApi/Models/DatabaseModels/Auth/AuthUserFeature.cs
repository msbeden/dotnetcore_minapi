using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthUserFeature : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long AuthUserFeatureId { get; set; }
        [ForeignKey("User")]
        public int AuthUserId { get; set; }
        public virtual AuthUser User { get; set; }
        [ForeignKey("Feature")]
        public int AuthFeatureId { get; set; }
        public virtual AuthFeature Feature { get; set; }
        public int AuthFeatureValue { get; set; }
    }
}
