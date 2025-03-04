using System.ComponentModel.DataAnnotations;

namespace BlazorGame.Models.ViewModels;

public class RegisterViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide an e-mail")]
    public string? Email { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a user name")]
    public string? Username { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a password")]
    public string? Password { get; set; }
}
