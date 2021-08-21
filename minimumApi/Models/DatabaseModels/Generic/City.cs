using minimumApi.Configuration.GenericDefinitionsConfiguration;
using minimumApi.Models.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels
{
    public class City : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CityId { get; set; }
        [Name]
        public string CityName { get; set; }
        public string PlateCode { get; set; }

        [ForeignKey("Country")]
        public int CountryId { get; set; }
        public virtual Country Country { get; set; }
        public virtual IList<Town> Towns { get; set; }
    }
}
