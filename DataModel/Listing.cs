using Airbnb.API.DataSerialization;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Airbnb.API.DataModel;

[BsonIgnoreExtraElements]
public class Listing : BaseEntity
{
    [BsonId]
    [BsonElement("id")]
    [JsonPropertyName("id")]
    public string? id { get; set; }

    [BsonElement("listingUrl")]
    [JsonPropertyName("listingUrl")]
    public string? listing_url { get; set; }

    [BsonElement("name")]
    [JsonPropertyName("name")]
    public string? name { get; set; }

    [BsonElement("summary")]
    [JsonPropertyName("summary")]
    public string? summary { get; set; }

    [BsonElement("space")]
    [JsonPropertyName("space")]
    public string? space { get; set; }

    [BsonElement("description")]
    [JsonPropertyName("description")]
    public string? description { get; set; }

    [BsonElement("neighborhoodOverview")]
    [JsonPropertyName("neighborhoodOverview")]
    public string? neighborhood_overview { get; set; }

    [BsonElement("notes")]
    [JsonPropertyName("notes")]
    public string? notes { get; set; }

    [BsonElement("transit")]
    [JsonPropertyName("transit")]
    public string? transit { get; set; }

    [BsonElement("access")]
    [JsonPropertyName("acceess")]
    public string? access { get; set; }

    [BsonElement("interaction")]
    [JsonPropertyName("interaction")]
    public string? interaction { get; set; }

    [BsonElement("houseRules")]
    [JsonPropertyName("houseRules")]
    public string? house_rules { get; set; }

    [BsonElement("propertyType")]
    [JsonPropertyName("propertyType")]
    public string? property_type { get; set; }

    [BsonElement("roomType")]
    [JsonPropertyName("roomType")]
    public string? room_type { get; set; }

    [BsonElement("bedType")]
    [JsonPropertyName("bedType")]
    public string? bed_type { get; set; }

    [BsonElement("minimumNights")]
    [JsonPropertyName("minimumNights")]
    public string? minimum_nights { get; set; }

    [BsonElement("maximumNights")]
    [JsonPropertyName("maximumNights")]
    public string? maximum_nights { get; set; }

    [BsonElement("cancellationPolicy")]
    [JsonPropertyName("cancellationPolicy")]
    public string? cancellation_policy { get; set; }

    [BsonElement("lastScraped")]
    [JsonPropertyName("lastScraped")]
    public DateOnly last_scraped { get; set; }

    [BsonElement("calendarLastScraped")]
    [JsonPropertyName("calendarLatScraped")]
    public DateOnly calendar_last_scraped { get; set; }

    [BsonElement("firstReview")]
    [JsonPropertyName("firstReview")]
    public DateOnly first_review { get; set; }

    [BsonElement("lastReview")]
    [JsonPropertyName("lastReview")]
    public DateOnly last_review { get; set; }

    [BsonElement("accommodates")]
    [JsonPropertyName("accommodates")]
    public int accommodates { get; set; }

    [BsonElement("bedrooms")]
    [JsonPropertyName("bedrooms")]
    public int bedrooms { get; set; }

    [BsonElement("beds")]
    [JsonPropertyName("beds")]
    public int beds { get; set; }

    [BsonElement("numberOfReviews")]
    [JsonPropertyName("numberOfReviews")]
    public int number_of_reviews { get; set; }

    [BsonElement("bathrooms")]
    [JsonPropertyName("bathrooms")]
    public decimal bathrooms { get; set; }

    [BsonElement("amenities")]
    [JsonPropertyName("amenities")]
    public List<string>? amenities { get; set; }

    [BsonElement("price")]
    [JsonPropertyName("price")]
    public decimal price { get; set; }

    [BsonElement("securitDeposit")]
    [JsonPropertyName("securitDeposit")]
    public decimal security_deposit { get; set; }

    [BsonElement("cleaningFee")]
    [JsonPropertyName("cleaningFee")]
    public decimal cleaning_fee { get; set; }

    [BsonElement("extraPeople")]
    [JsonPropertyName("extraPeople")]
    public decimal extra_people { get; set; }

    [BsonElement("guestsIncluded")]
    [JsonPropertyName("guestsIncluded")]
    public decimal guests_included { get; set; }

    [BsonElement("images")]
    [JsonPropertyName("images")]
    public Images? images { get; set; }

    [BsonElement("host")]
    [JsonPropertyName("host")]
    public Host? host { get; set; }

    [BsonElement("address")]
    [JsonPropertyName("address")]
    public Address? address { get; set; }

    [BsonElement("availability")]
    [JsonPropertyName("availability")]
    public Availability? availability { get; set; }

    [BsonElement("reviewScores")]
    [JsonPropertyName("reviewScores")]
    public ReviewScores? review_scores { get; set; }

    [BsonElement("reviews")]
    [JsonPropertyName("reviews")]
    public List<Review>? reviews { get; set; }
}