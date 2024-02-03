using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Host
{
    [BsonId]
    [BsonElement("hostId")]
    [JsonPropertyName("hostId")]
    public string? host_id { get; set; }

    [BsonElement("hostUrl")]
    [JsonPropertyName("hostUrl")]
    public string? host_url { get; set; }

    [BsonElement("hostName")]
    [JsonPropertyName("hostName")]
    public string? host_name { get; set; }

    [BsonElement("hostLocation")]
    [JsonPropertyName("hostLocation")]
    public string? host_location { get; set; }

    [BsonElement("hostAbout")]
    [JsonPropertyName("hostAbout")]
    public string? host_about { get; set; }

    [BsonElement("hostResponseTime")]
    [JsonPropertyName("hostResponseTime")]
    public string? host_response_time { get; set; }

    [BsonElement("hostThumbnailUrl")]
    [JsonPropertyName("hostThumbnailUrl")]
    public string? host_thumbnail_url { get; set; }

    [BsonElement("hostPictureUrl")]
    [JsonPropertyName("hostPictureUrk")]
    public string? host_picture_url { get; set; }

    [BsonElement("hostNeighbourhood")]
    [JsonPropertyName("hostNeighbourhood")]
    public string? host_neighbourhood { get; set; }

    [BsonElement("hostResponseRate")]
    [JsonPropertyName("hostResponseRate")]
    public int host_response_rate { get; set; }

    [BsonElement("hostIsSuperHost")]
    [JsonPropertyName("hostIsSuperHost")]
    public bool host_is_superhost { get; set; }

    [BsonElement("hostHasProfilePic")]
    [JsonPropertyName("hostHasProfilePic")]
    public bool host_has_profile_pic { get; set; }

    [BsonElement("hostIdentityVerified")]
    [JsonPropertyName("hostIdentityVerified")]
    public bool host_identity_verified { get; set; }

    [BsonElement("hostListingsCount")]
    [JsonPropertyName("hostingListingsCount")]
    public int host_listings_count { get; set; }

    [BsonElement("hostTotalListingsCount")]
    [JsonPropertyName("hostTotalListingsCount")]
    public int host_total_listings_count { get; set; }

    [BsonElement("hostVerifications")]
    [JsonPropertyName("hostVerifications")]
    public List<string>? host_verifications { get; set; }
}