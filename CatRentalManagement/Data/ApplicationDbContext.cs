using CatRentalManagement.Configurations.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CatRentalManagement.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<CatRentalManagement.Domain.Vehicle> Vehicle { get; set; } = default!;
        public DbSet<CatRentalManagement.Domain.Booking> Booking { get; set; } = default!;
        public DbSet<CatRentalManagement.Domain.Customer> Customer { get; set; } = default!;
        public DbSet<CatRentalManagement.Domain.Colour> Colour { get; set; } = default!;
        public DbSet<CatRentalManagement.Domain.Model> Model { get; set; } = default!;
        public DbSet<CatRentalManagement.Domain.Make> Make { get; set; } = default!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new ColourSeed());
            builder.ApplyConfiguration(new MakeSeed());
            builder.ApplyConfiguration(new ModelSeed());
        }
    }
}
