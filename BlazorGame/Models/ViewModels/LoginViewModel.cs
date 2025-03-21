using System.ComponentModel.DataAnnotations;

namespace BlazorGame.Models.ViewModels;

public class LoginViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a user name")]
    public string? Username { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide a password")]
    public string? Password { get; set; }
}