namespace API.Data;

using API.Entities;
using Microsoft.EntityFrameworkCore;
public class DataContext(DbContextOptions options) : DbContext(options) //parent class overriden constructor primary constructor
{
    public DbSet<AppUser> Users { get; set; }
    
}
