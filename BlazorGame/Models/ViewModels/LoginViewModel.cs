using System.ComponentModel.DataAnnotations;

namespace BlazorGame.Models.ViewModels;

public class LoginViewModel
{
    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide user name")]
    public string? Username { get; set; }

    [Required(AllowEmptyStrings = false, ErrorMessage = "Please provide password")]
    public string? Password { get; set; }
}