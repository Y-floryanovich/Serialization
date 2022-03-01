using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    public interface ISerialization
    {
        void Serialize(Department department, string fileName);

        Department Deserialize(string fileName);
    }
}
