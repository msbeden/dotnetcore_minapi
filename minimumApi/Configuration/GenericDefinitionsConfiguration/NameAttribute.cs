using System;

namespace minimumApi.Configuration.GenericDefinitionsConfiguration
{
    [AttributeUsage(AttributeTargets.Property)]
    public class NameAttribute : Attribute
    {
        public NameAttribute()
        {

        }
    }
}
