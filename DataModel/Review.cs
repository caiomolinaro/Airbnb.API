using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Review
{
    [BsonId]
    [BsonElement("reviewId")]
    [JsonPropertyName("reviewId")]
    public string? _id { get; set; }

    [BsonElement("reviewDate")]
    [JsonPropertyName("reviewDate")]
    public DateTime date { get; set; }

    [BsonElement("listingId")]
    [JsonPropertyName("listingId")]
    public string? listing_id { get; set; }

    [BsonElement("reviewerId")]
    [JsonPropertyName("reviewerId")]
    public string? reviewer_id { get; set; }

    [BsonElement("reviewerName")]
    [JsonPropertyName("reviewerName")]
    public string? reviewer_name { get; set; }

    [BsonElement("comments")]
    [JsonPropertyName("comments")]
    public string? comments { get; set; }
}