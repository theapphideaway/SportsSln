using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoredDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoredDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Kayak",
                        Description = "A boat for one person",
                        Category = "Watersports", 
                        Price = 275
                    },
                    new Product
                    {
                        Name = "Life Jacket",
                        Description = "Stay afloat off the boat",
                        Category = "Watersports",
                        Price = 48.95m
                    },
                    new Product
                    {
                        Name = "Soccer Ball",
                        Description = "FIFA-approved size and weight",
                        Category = "Soccer",
                        Price = 19.50m
                    },
                    new Product
                    {
                        Name = "Corner Flags",
                        Description = "Give your playing field a professional touch",
                        Category = "Soccer",
                        Price = 34.95m
                    },
                    new Product
                    {
                        Name = "Right Handed Hockey Stick",
                        Description = "Hockey stick for forwards or defensemen",
                        Category = "Hockey",
                        Price = 50
                    },
                    new Product
                    {
                        Name = "Left Handed Hockey Stick",
                        Description = "Hockey stick for forwards or defensemen",
                        Category = "Hockey",
                        Price = 50
                    },
                    new Product
                    {
                        Name = "Hockey Goal",
                        Description = "NHL sized hockey goal with net",
                        Category = "Hockey",
                        Price = 400
                    },
                    new Product
                    {
                        Name = "Pull Up Bar",
                        Description = "Pull up bar made for doorways",
                        Category = "Fitness",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "Football",
                        Description = "NFL-approved size and weight",
                        Category = "Football",
                        Price = 25
                    },
                    new Product
                    {
                        Name = "Golf Club Set",
                        Description = "A beginner set of clubs, includes all standard clubs",
                        Category = "Golf",
                        Price = 200
                    },
                    new Product
                    {
                        Name = "Golf Balls 9 set",
                        Description = "Standard golf balls",
                        Category = "Golf",
                        Price = 10
                    }
                    );
                context.SaveChanges();
            }
        }
    }
}
