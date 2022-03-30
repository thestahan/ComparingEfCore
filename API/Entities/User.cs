using System.Text.Json.Serialization;

namespace API.Entities;

public class User
{
    public int Id { get; set; }

    public string? Uid { get; set; }

    public string? Password { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Username { get; set; }

    public string? Email { get; set; }

    public string? Avatar { get; set; }

    public string? Gender { get; set; }

    public string? PhoneNumber { get; set; }

    public string? SocialInsuranceNumber { get; set; }

    public string? DateOfBirth { get; set; }

    public ICollection<Address> Addresses { get; set; }
}
