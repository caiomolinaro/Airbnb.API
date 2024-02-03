using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class ReviewScores
{
    [BsonElement("reviewScoresAccuracy")]
    [JsonPropertyName("reviewScoresAccuracy")]
    public int review_scores_accuracy { get; set; }

    [BsonElement("reviewScoresCleanliness")]
    [JsonPropertyName("reviewScoresCleanliness")]
    public int review_scores_cleanliness { get; set; }

    [BsonElement("reviewScoresCheckin")]
    [JsonPropertyName("reviewScoresCheckin")]
    public int review_scores_checkin { get; set; }

    [BsonElement("reviewScoresCommunication")]
    [JsonPropertyName("reviewScoresCommunication")]
    public int review_scores_communication { get; set; }

    [BsonElement("reviewScoresLocation")]
    [JsonPropertyName("reviewScoresLocation")]
    public int review_scores_location { get; set; }

    [BsonElement("reviewScoresValue")]
    [JsonPropertyName("reviewScoresValue")]
    public int review_scores_value { get; set; }

    [BsonElement("reviewScoresRating")]
    [JsonPropertyName("reviewScoresRating")]
    public int review_scores_rating { get; set; }
}