using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Department : ICloneable
    {
        public string DepartmentName { get; set; }

        [XmlArray("Workers")]
        [XmlArrayItem("Worker")]
        [JsonPropertyName("Workers")]
        public List<Employee> Employees { get; set; }

        public object Clone()
        {
            using (var stream = new MemoryStream())
                if (GetType().IsSerializable)
                {
                    var startPosition = 0;
                    var formatter = new BinaryFormatter();
                    formatter.Serialize(stream, this);
                    stream.Position = startPosition;
                    return formatter.Deserialize(stream);
                }
            return null;
        }
    }
}
