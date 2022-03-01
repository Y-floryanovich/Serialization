using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Serialization
{
    [Serializable]
    public class Department
    {
        public string DepartmentName { get; set; }

        [XmlArray("Workers")]
        [XmlArrayItem("Worker")]
        [JsonPropertyName("Workers")]
        public List<Employee> Employees { get; set; }
    }
}
