using minimumApi.Models.Abstractions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels.Auth
{
    public class AuthGroup : BaseEntity, IDbDeletable
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthGroupId { get; set; }
        public string AuthGroupName { get; set; }
        public bool IsEnabled { get; set; }
        public bool IsDeleted { get; set; }
        public int Priority { get; set; }
    }

    public enum AuthGroupPriorities
    {
        Highest = 0,
        High = 1,
        Low = 2,
        Lowest = 3
    }
}
