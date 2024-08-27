using Microsoft.EntityFrameworkCore;
using Models;
using Services;

public class MojStolDbContext: DbContext {
  public MojStolDbContext(DbContextOptions < MojStolDbContext > options): base(options) {}

  public DbSet < User > Users { get; set; }
  public DbSet < Role > Roles { get; set; }

  protected override void OnModelCreating(ModelBuilder modelBuilder) {
    modelBuilder.Entity < User > ()
      .Property(u => u.UserId)
      .ValueGeneratedOnAdd();

    modelBuilder.Entity < User > ()
      .HasIndex(u => u.Email)
      .IsUnique();

    var passwordHelper = new PasswordHelper();

    var (passwordHash, passwordSalt) = passwordHelper.CreatePasswordHash("AdminPass");

    modelBuilder.Entity < Role > ().HasData(
      new Role {
        RoleID = 1, Name = "Admin"
      },
      new Role {
        RoleID = 2, Name = "User"
      }
    );

    modelBuilder.Entity < User > ().HasData(
      new User {
        UserId = -1,
          Name = "Admin",
          Surname = "Account",
          Email = "admin@gmail.com",
          PasswordHash = passwordHash,
          PasswordSalt = passwordSalt,
          RoleId = 1, 
          IsActive = true,
          CreatedAt = DateTime.UtcNow
      }
    );

    base.OnModelCreating(modelBuilder);
  }
}