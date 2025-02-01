using System.IO;
using System.Text.Json;

namespace MovieManagementSystem.DataAccess
{
    public class JsonHelper
    {
        public static void SaveToFile<T>(string filePath, T data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, jsonString);
        }

        public static T LoadFromFile<T>(string filePath)
        {
            if (!File.Exists(filePath))
                return default(T);

            var jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<T>(jsonString);
        }
    }
}
