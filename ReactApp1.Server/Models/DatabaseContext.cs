using Microsoft.EntityFrameworkCore;
using ReactApp1.Server.Classes;

public class DatabaseContext : DbContext
{
    public DbSet<BedrijfsAccount> BedrijfsAccounts { get; set; }
    public DbSet<BeheerdersAccount> BeheerdersAccounts { get; set; }
    public DbSet<HuurdersAccount> HuurdersAccounts { get; set; }
    public DbSet<MedewerkersAccount> MedewerkersAccounts { get; set; }

    public DbSet<Auto> Autos { get; set; }
    public DbSet<Caravan> Caravans { get; set; }
    public DbSet<Camper> Campers { get; set; }

    public DbSet<HuurAanvraag> HuurAanvragen { get; set; }

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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // configurating abstraction of Voertuig
        modelBuilder.Entity<Auto>(entity =>
        {
            entity.HasKey(e => e.voertuigId); // Explicitly set the primary key
        });
        modelBuilder.Entity<Caravan>(entity =>
        {
            entity.HasKey(e => e.voertuigId); // Explicitly set the primary key
        });
        modelBuilder.Entity<Camper>(entity =>
        {
            entity.HasKey(e => e.voertuigId); // Explicitly set the primary key
        });


        // configuration abstraction of Account
        //modelBuilder.Entity<BedrijfsAccount>(entity =>
        //{
        //    entity.HasKey(e => e.accountId); // Explicitly set the primary key
        //});
        //modelBuilder.Entity<BeheerdersAccount>(entity =>
        //{
        //    entity.HasKey(e => e.accountId); // Explicitly set the primary key
        //});
        //modelBuilder.Entity<HuurdersAccount>(entity =>
        //{
        //    entity.HasKey(e => e.accountId); // Explicitly set the primary key
        //});
        //modelBuilder.Entity<MedewerkersAccount>(entity =>
        //{
        //    entity.HasKey(e => e.accountId); // Explicitly set the primary key
        //});

        modelBuilder.Entity<HuurAanvraag>()
        .HasKey(h => h.huurAanvraagId);

        base.OnModelCreating(modelBuilder); // Don't forget to call the base method
    }
}
