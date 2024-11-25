using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Classes;

public class DatabaseContext : DbContext
{
    public DbSet<Account> Accounts { get; set; }
    public DbSet<Voertuig> Voertuigen { get; set; }

    // Constructor for DI (Dependency Injection)
    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {

    }

    // Configure the database options here only if not using DI
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}
