using Microsoft.EntityFrameworkCore;

namespace BlazorGame.Models.Entities;

[Index(nameof(Username))]
public class User(string username, string password)
{
    public int Id { get; set; }
    public string Username { get; set; } = username;
    public string Password { get; set; } = password;
    public int BestScore { get; set; } = 0;
}
