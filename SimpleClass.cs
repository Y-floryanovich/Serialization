using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace Serialization
{
    [Serializable]
    public class SimpleClass : ISerializable
    {
        public string FirstProperty { get; set; }
        public int SecondProperty { get; set; }

        public SimpleClass()
        {

        }
        public SimpleClass(SerializationInfo info, StreamingContext context)
        {
            FirstProperty = info.GetString("FirstProp");
            SecondProperty = info.GetInt32("SecondProp");
        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("SecondProp", FirstProperty);
            info.AddValue("SecondProp", SecondProperty);
        }
    }
}
