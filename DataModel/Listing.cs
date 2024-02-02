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

[BsonIgnoreExtraElements]
public class Listing
{
    [BsonId]
    [BsonElement("id")]
    [JsonPropertyName("id")]
    public string? _id { get; set; }

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