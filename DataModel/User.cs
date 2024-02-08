using System.ComponentModel.DataAnnotations;

namespace Airbnb.API.DataModel;

public class User
{
    [Required]
    public string? Name { get; set; }

    [Required]
    [EmailAddress(ErrorMessage = "Invalid email")]
    public string? Email { get; set; }

    [Required]
    public string? Password { get; set; }
}