using System.Text.Json.Serialization;

namespace API.Data.SeederDtos;

public class AddressSeedDto
{
    [JsonPropertyName("uid")]
    public string Uid { get; set; }

    [JsonPropertyName("city")]
    public string City { get; set; }

    [JsonPropertyName("street_name")]
    public string StreetName { get; set; }

    [JsonPropertyName("street_address")]
    public string StreetAddress { get; set; }

    [JsonPropertyName("secondary_address")]
    public string SecondaryAddress { get; set; }

    [JsonPropertyName("building_number")]
    public string BuildingNumber { get; set; }

    [JsonPropertyName("mail_box")]
    public string MailBox { get; set; }

    [JsonPropertyName("community")]
    public string Community { get; set; }

    [JsonPropertyName("zip_code")]
    public string ZipCode { get; set; }

    [JsonPropertyName("zip")]
    public string Zip { get; set; }

    [JsonPropertyName("postcode")]
    public string Postcode { get; set; }

    [JsonPropertyName("time_zone")]
    public string TimeZone { get; set; }

    [JsonPropertyName("street_suffix")]
    public string StreetSuffix { get; set; }

    [JsonPropertyName("city_suffix")]
    public string CitySuffix { get; set; }

    [JsonPropertyName("city_prefix")]
    public string CityPrefix { get; set; }

    [JsonPropertyName("state")]
    public string State { get; set; }

    [JsonPropertyName("state_abbr")]
    public string StateAbbr { get; set; }

    [JsonPropertyName("country")]
    public string Country { get; set; }

    [JsonPropertyName("country_code")]
    public string CountryCode { get; set; }

    [JsonPropertyName("latitude")]
    public double Latitude { get; set; }

    [JsonPropertyName("longitude")]
    public double Longitude { get; set; }

    [JsonPropertyName("full_address")]
    public string FullAddress { get; set; }
}
