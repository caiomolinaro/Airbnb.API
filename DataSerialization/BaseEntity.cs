namespace Airbnb.API.DataSerialization;

public class BaseEntity
{
    public List<string>? SerializableProperties { get; set; }

    public void SetSerializableProperties(string fields)
    {
        if (!string.IsNullOrEmpty(fields))
        {
            var returnFields = fields.Split(new char[] { ',' },
                StringSplitOptions.RemoveEmptyEntries);

            SerializableProperties = returnFields.ToList();

            return;
        }

        var members = GetType().GetMembers();

        SerializableProperties = new List<string>();

        SerializableProperties.AddRange(members.Select(m => m.Name).ToList());
    }
}