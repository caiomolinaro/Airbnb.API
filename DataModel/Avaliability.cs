using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Availability
{
    [BsonElement("availability30")]
    [JsonPropertyName("availability30")]
    public int availability_30 { get; set; }

    [BsonElement("availability60")]
    [JsonPropertyName("availability60")]
    public int availability_60 { get; set; }

    [BsonElement("availability90")]
    [JsonPropertyName("availability90")]
    public int availability_90 { get; set; }

    [BsonElement("availability365")]
    [JsonPropertyName("availability365")]
    public int availability_365 { get; set; }
}