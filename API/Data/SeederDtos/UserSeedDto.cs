using System.Text.Json.Serialization;

namespace API.Data.SeederDtos;

public class UserSeedDto
{
    [JsonPropertyName("uid")]
    public string Uid { get; set; }

    [JsonPropertyName("password")]
    public string Password { get; set; }

    [JsonPropertyName("first_name")]
    public string FirstName { get; set; }

    [JsonPropertyName("last_name")]
    public string LastName { get; set; }

    [JsonPropertyName("username")]
    public string Username { get; set; }

    [JsonPropertyName("email")]
    public string Email { get; set; }

    [JsonPropertyName("avatar")]
    public string Avatar { get; set; }

    [JsonPropertyName("gender")]
    public string Gender { get; set; }

    [JsonPropertyName("phone_number")]
    public string PhoneNumber { get; set; }

    [JsonPropertyName("social_insurance_number")]
    public string SocialInsuranceNumber { get; set; }

    [JsonPropertyName("date_of_birth")]
    public string DateOfBirth { get; set; }
}
