using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Classes;
using System.Diagnostics;

public sealed class DatabaseContext : DbContext
{
    

    public DbSet<Account> Accounts { get; set; }

    private DatabaseContext() { }
    private static DatabaseContext instance;


    public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
    {
    }

    public static DatabaseContext GetInstance()
    {
        if (instance == null)
        {
            instance = new DatabaseContext();
        }
        return instance;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlite("Data Source=database.db");
        }
    }
}
