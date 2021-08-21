using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthFeature : BaseEntity, IDbDeletable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthFeatureId { get; set; }
        public string AuthFeatureName { get; set; }
        public string AuthFeatureTableName { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
    }
}
