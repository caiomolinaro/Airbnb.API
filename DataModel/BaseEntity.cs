namespace Airbnb.API.DataModel;

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

        var members = this.GetType().GetMembers();

        SerializableProperties = new List<string>();

        SerializableProperties.AddRange(members.Select(m => m.Name).ToList());
    }
}