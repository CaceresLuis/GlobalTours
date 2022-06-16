using Core.Entities;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class SeedDb
    {
        public static async Task SeedAsync(ApplicationDbContext context, ILoggerFactory loggerF)
        {
            try
            {
                if (!context.Countries.Any())
                {
                    List<Country> countries = new()
                    {
                        new Country() { Name = "Canada" },
                        new Country() { Name = "United Kingdom" },
                        new Country() { Name = "Australia" },
                        new Country() { Name = "New Zealand" },
                        new Country() { Name = "Germany" },
                        new Country() { Name = "France" },
                        new Country() { Name = "Italy" },
                        new Country() { Name = "Spain" },
                        new Country() { Name = "Brazil" },
                        new Country() { Name = "Argentina" },
                        new Country() { Name = "Chile" },
                        new Country() { Name = "Colombia" },
                        new Country() { Name = "Peru" },
                        new Country() { Name = "Uruguay" },
                        new Country() { Name = "Bolivia" },
                        new Country() { Name = "Paraguay" },
                        new Country() { Name = "Ecuador" },
                        new Country() { Name = "El Salvador" },
                        new Country() { Name = "Honduras" },
                        new Country() { Name = "Jamaica" },
                        new Country() { Name = "Nicaragua" },
                        new Country() { Name = "Costa Rica" },
                        new Country() { Name = "Panama" },
                    };
                    context.Countries.AddRange(countries);
                    await context.SaveChangesAsync();
                }

                if (!context.Categories.Any())
                {
                    List<Category> categories = new()
                    {
                        new Category() { Name = "Automotive" },
                        new Category() { Name = "Beauty" },
                        new Category() { Name = "Books" },
                        new Category() { Name = "Clothing" },
                        new Category() { Name = "Electronics" },
                        new Category() { Name = "Furniture" },
                        new Category() { Name = "Garden" },
                        new Category() { Name = "Home" },
                        new Category() { Name = "Jewelry" },
                        new Category() { Name = "Kitchen" },
                        new Category() { Name = "Movies" },
                        new Category() { Name = "Music" },
                    };
                    context.Categories.AddRange(categories);
                    await context.SaveChangesAsync();
                }

                if (!context.Places.Any())
                {
                    List<Place> places = new()
                    {
                        new Place() {ApproximateExpenses = 12, ImageUrl = "image1", Description = "Automotive", IdCategory  = 1, IdCountry = 1, Name = "Automotive"},
                        new Place() { Name = "Beauty", ImageUrl = "image2", ApproximateExpenses = 45, Description = "Beauty", IdCategory  = 2, IdCountry = 2},
                        new Place() { Name = "Books", ImageUrl = "image3", ApproximateExpenses = 32, Description = "Books", IdCategory  = 3, IdCountry = 3 },
                        new Place() { Name = "Clothing", ImageUrl = "image4", ApproximateExpenses = 87, Description = "Clothing", IdCategory  = 4, IdCountry = 4 },
                    };
                    context.Places.AddRange(places);
                    await context.SaveChangesAsync();
                }
            }
            catch (Exception e)
            {
                ILogger<SeedDb> logger = loggerF.CreateLogger<SeedDb>();
                string message = e.Message;
                logger.LogError(message);
            }
        }

    }
}
