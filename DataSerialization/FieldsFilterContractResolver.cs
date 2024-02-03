using Airbnb.API.DataModel;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Airbnb.API.DataSerialization;

public class FieldsFilterContractResolver : DefaultContractResolver
{
    protected override JsonProperty CreateProperty(System.Reflection.MemberInfo member, MemberSerialization memberSerialization)
    {
        var property = base.CreateProperty(member, memberSerialization);

        if (property.DeclaringType == typeof(BaseEntity) || property.DeclaringType!.BaseType == typeof(BaseEntity))
        {
            if (property.PropertyName == "SerializableProperties")
            {
                property.ShouldSerialize = instance => { return false; };
            }
            else
            {
                property.ShouldSerialize = instance =>
                {
                    if (instance.GetType() == typeof(Listing))
                    {
                        var p = (Listing)instance;

                        return p.SerializableProperties!.Contains(property.PropertyName!);
                    }
                    return false;
                };
            }
        }
        return property;
    }
}