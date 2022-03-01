using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Serialization;

namespace BinarySerialization
{
    public class Binary : ISerialization
    {
        public Department Deserialize(string fileName)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var department = (Department)formatter.Deserialize(stream);
            stream.Close();
            return department;
        }

        public void Serialize(Department department, string fileName)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, department);
            stream.Close();
        }
    }
}
