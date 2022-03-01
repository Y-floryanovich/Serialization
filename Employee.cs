using System;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Employee
    {
        [XmlElement("WorkerName")]
        [JsonPropertyName("WorkerName")]
        public string EmployeeName { get; set; }
    }
}
