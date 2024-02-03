using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Images
{
    [BsonElement("thumbnailUrl")]
    [JsonPropertyName("thumbnailUrl")]
    public string? thumbnail_url { get; set; }

    [BsonElement("mediumUrl")]
    [JsonPropertyName("mediumUrl")]
    public string? medium_url { get; set; }

    [BsonElement("pictureUrl")]
    [JsonPropertyName("pictureUrl")]
    public string? picture_url { get; set; }

    [BsonElement("xlPictureUrl")]
    [JsonPropertyName("xlPictureUrl")]
    public string? xl_picture_url { get; set; }
}