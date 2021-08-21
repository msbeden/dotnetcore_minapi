using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace minimumApi.Extensions
{
    public static class JsonOperationsExtensions
    {
        public static IEnumerable<JsonElement> GetJsonObjects(this string filePath)
        {
            IEnumerable<JsonElement> jsonData;
            using (StreamReader jsonStreamReader = new StreamReader(path: filePath, encoding: Encoding.UTF8))
            {
                string data = jsonStreamReader.ReadToEnd();
                jsonData = JsonSerializer.Deserialize<IEnumerable<JsonElement>>(data);
            }
            return jsonData;
        }

        public static IEnumerable<T> GetJsonByPropertyName<T>(this string filePath, string propertyName)
        {
            List<JsonElement> jsonData;
            List<T> results;
            using (StreamReader jsonStreamReader = new StreamReader(path: filePath, encoding: Encoding.UTF8))
            {
                string data = jsonStreamReader.ReadToEnd();
                jsonData = JsonSerializer.Deserialize<List<JsonElement>>(data);
                results = (List<T>)jsonData.Select(x => Convert.ChangeType(x.GetProperty(propertyName), typeof(T)));
            }
            return results;
        }
    }
}
