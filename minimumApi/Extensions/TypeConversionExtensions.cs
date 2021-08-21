using System;

namespace minimumApi.Extensions
{
    public static class TypeConversionExtensions
    {
        public static TimeSpan ToTimeSpan(this string source) => TimeSpan.TryParse(source, out TimeSpan result) ? result : default;
    }
}
