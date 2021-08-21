using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimumApi.Configuration.Authorization
{
    [AttributeUsage(AttributeTargets.All)]
    public class RoleAttribute :  Attribute
    {
        public RoleAttribute()
        {

        }


    }
}
