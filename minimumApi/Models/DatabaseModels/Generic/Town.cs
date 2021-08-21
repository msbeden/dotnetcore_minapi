using minimumApi.Configuration.GenericDefinitionsConfiguration;
using minimumApi.Models.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels
{
    public class Town : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TownId { get; set; }
        [Name]
        public string TownName { get; set; }
        [ForeignKey("City")]
        public int CityId { get; set; }
        public virtual City City { get; set; }
    }
}
