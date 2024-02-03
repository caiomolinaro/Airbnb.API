using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Address
{
    [BsonElement("street")]
    [JsonPropertyName("street")]
    public string? street { get; set; }

    [BsonElement("suburb")]
    [JsonPropertyName("suburd")]
    public string? suburb { get; set; }

    [BsonElement("governmentArea")]
    [JsonPropertyName("governmentArea")]
    public string? government_area { get; set; }

    [BsonElement("market")]
    [JsonPropertyName("market")]
    public string? market { get; set; }

    [BsonElement("country")]
    [JsonPropertyName("country")]
    public string? country { get; set; }

    [BsonElement("countryCode")]
    [JsonPropertyName("countryCode")]
    public string? country_code { get; set; }

    [BsonElement("location")]
    [JsonPropertyName("location")]
    public Location? location { get; set; }
}