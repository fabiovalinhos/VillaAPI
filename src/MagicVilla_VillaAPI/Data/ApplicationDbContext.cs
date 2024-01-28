using MagicVilla_VillaAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace MagicVilla_VillaAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<LocalUser> LocalUsers { get; set; }
        public DbSet<Villa> Villas { get; set; }
        public DbSet<VillaNumber> VillaNumbers { get; set; }


        // ele nao usou o mapping ao criar a migration.
        // este método foi criado depois da migration.
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Villa>().HasData(
                new Villa
                {
                    Id = 1,
                    Name = "Royal Villa",
                    Details = "Esta área é description",
                    ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa1.jpg",
                    Occupancy = 5,
                    Rate = 200,
                    Sqft = 500,
                    Amenity = "",
                    CreatedDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                },
                new Villa
                {
                    Id = 2,
                    Name = "Diamond Villa",
                    Details = "Diamond detalhes",
                    ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa2.jpg",
                    Occupancy = 3,
                    Rate = 500,
                    Sqft = 450,
                    Amenity = "",
                    CreatedDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                },
                new Villa
                {
                    Id = 3,
                    Name = "Ruby Villa",
                    Details = "Ruby detalhes",
                    ImageUrl = "https://www.dotnetmastery.com/bluevillaimages/villa3.jpg",
                    Occupancy = 6,
                    Rate = 100,
                    Sqft = 700,
                    Amenity = "",
                    CreatedDate = DateTime.UtcNow,
                    UpdateDate = DateTime.UtcNow
                }
            );
        }
    }
}