using BlazorGame.Models.Entities;

namespace BlazorGame.Data;

using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
        => options.UseSqlite("Data Source=/home/tomas337/RiderProjects/BlazorGame/BlazorGameDB/blazorgamedb.sqlite");
}