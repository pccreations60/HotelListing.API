using Microsoft.EntityFrameworkCore;

namespace HotelListing.API.Data
{
    public class HotelListingDbContext: DbContext
    {
        public HotelListingDbContext(DbContextOptions options) :base(options)
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
                    Id=2,
                    Name = "NiggerVille",
                    ShortName = "NV"
                },
                new Country
                {
                    Id=3,
                    Name = "Nigger Resorts",
                    ShortName = "NR"
                }
            );

            modelBuilder.Entity<Hotel>().HasData(

            new Hotel
            {
                Id = 1,
                Name = "Nigger Heaven",
                Address = "Darkie Corner",
                CountryId = 1,
                Rating = 2.0
            },
            new Hotel
            {
                Id = 2,
                Name = "Shit Skin Bungalo",
                Address = "Jungle Bunny Woods",
                CountryId = 3,
                Rating = 5.0
            },
            new Hotel
            {
                Id = 3,
                Name = "Porch Monkey Digs",
                Address = "Atlanta",
                CountryId = 2,
                Rating = 1
            }
            );

        }
    }
}
