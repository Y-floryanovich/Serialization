using System.IO;
using System.Text.Json;
using Serialization;

namespace JsonSerialization
{
    public class Json : ISerialization
    {
        public void Serialize(Department department, string fileName)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            var jsonString = JsonSerializer.Serialize(department, options);
            File.WriteAllText(fileName, jsonString);
        }

        public Department Deserialize(string fileName)
        {
            var jsonString = File.ReadAllText(fileName);
            var department = JsonSerializer.Deserialize<Department>(jsonString);
            return department;
        }
    }
}
