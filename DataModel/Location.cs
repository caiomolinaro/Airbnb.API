using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Location
{
    [BsonElement("type")]
    [JsonPropertyName("type")]
    public string? type { get; set; }

    [BsonElement("coordinates")]
    [JsonPropertyName("coordinates")]
    public List<double>? coordinates { get; set; }

    [BsonElement("isLocationExact")]
    [JsonPropertyName("isLocationExacts")]
    public bool is_location_exact { get; set; }
}