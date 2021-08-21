using minimumApi.Configuration.GenericDefinitionsConfiguration;
using minimumApi.Models.Abstractions;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.DatabaseModels
{
    public class Country : BaseEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CountryId { get; set; }
        [Name]
        public string CountryName { get; set; }

        public virtual IList<City> Cities { get; set; }
    }
}
