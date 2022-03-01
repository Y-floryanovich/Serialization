using System.IO;
using System.Xml.Serialization;
using Serialization;

namespace XMLSerialization
{
    public class XML : ISerialization
    {
        public void Serialize(Department department, string fileName)
        {
            var serializer = new XmlSerializer(typeof(Department));
            var writer = new StreamWriter(fileName);
            serializer.Serialize(writer, department);
            writer.Close();
        }

        public Department Deserialize(string fileName)
        {
            var serializer = new XmlSerializer(typeof(Department));
            var fileStream = new FileStream(fileName, FileMode.Open);
            var department = (Department)serializer.Deserialize(fileStream);
            fileStream.Close();
            return department;
        }
    }
}
