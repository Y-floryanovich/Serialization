using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Serialization
{
    public class SerializeSimpleClass 
    {
        public void Serialize(SimpleClass simpleClass, string fileName)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(fileName, FileMode.Create, FileAccess.Write, FileShare.None);
            formatter.Serialize(stream, simpleClass);
            stream.Close();
        }

        public SimpleClass Deserialize(string fileName)
        {
            var formatter = new BinaryFormatter();
            var stream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.Read);
            var simpleClass = (SimpleClass)formatter.Deserialize(stream);
            stream.Close();
            return simpleClass;
        }
    }
}
