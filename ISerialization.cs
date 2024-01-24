namespace Serialization
{
    public interface ISerialization
    {
        void Serialize(Department department, string fileName);
        Department Deserialize(string fileName);
    }
}
