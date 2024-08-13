using Microsoft.EntityFrameworkCore;

namespace HotelListingAPI.Data
{
    public class HotelListingDbContext : DbContext
    {
        public HotelListingDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Country> Countries { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Country>().HasData(
                new Country
                {
                    Id = 1,
                    Name = "Jamaica",
                    ShortName = "JM"
                },
                new Country
                {
                    Id = 2,
                    Name = "Bahamas",
                    ShortName = "BS"
                },
                new Country
                {
                    Id = 3,
                    Name = "Cayman Islands",
                    ShortName = "CI"
                }
                );

            modelBuilder.Entity<Hotel>().HasData(
                new Hotel
                {
                   Id = 1,
                   Name = "Hotel Jamaica",
                   Address = "Calle Jamaica",
                   CountryId = 1,
                   Rating = 4.5
                },
                new Hotel
                {
                    Id = 2,
                    Name = "Hotel Bahamas",
                    Address ="Calle Bahamas",
                    CountryId = 2,
                    Rating = 4.1
                },
                new Hotel
                {
                    Id = 3,
                    Name = "Hotel Cayman Islands",
                    Address = "Calle Cayman Islands",
                    CountryId = 3,
                    Rating = 4.9
                }
                );
        }
    }
}
