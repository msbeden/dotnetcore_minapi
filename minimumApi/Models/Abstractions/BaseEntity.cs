using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace minimumApi.Models.Abstractions
{
    public abstract class BaseEntity
    {
        [NotMapped]
        public DateTime UsedTime => DateTime.Now;
    }
}