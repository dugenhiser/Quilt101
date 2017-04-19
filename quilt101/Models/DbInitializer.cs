using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using quilt101.Model;
using System.Collections.Generic;
using System.Linq;

namespace quilt101.Models
{
    public class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            AppDbContext context = applicationBuilder.ApplicationServices.GetRequiredService<AppDbContext>();

            if(!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Quilts.Any())
            {
                context.AddRange
                    (

                    new Quilt { Name = "Falling In Love", Price = 120, ShortDescription = "It's a Leaf", ImageUrl = "../images/fallingInLove.jpg" },
                    new Quilt { Name = "Sweet Strawberry", Price = 130, ShortDescription = "In the Mornin, I'm makin waffles", ImageUrl = "../images/sweetStrawberry.jpg" },
                    new Quilt { Name = "Lifes A Breeze", Price = 160, ShortDescription = "Baby Blanket", ImageUrl = "../images/lifesABreeze.jpg" },
                    new Quilt { Name = "Double Stripe", Price = 140, ShortDescription = "Pinkish Stripes", ImageUrl = "../images/FullSizeR.jpg" }
                   
                
                    );
            }
            
            context.SaveChanges();
        }

        private static Dictionary<string, Category> categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Baby Quilt"},
                        new Category { CategoryName = "Lap Quilt"}
                    };

                    categories = new Dictionary<string, Category>();

                    foreach(Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }

                }

                return categories;
            }
        }
    }
}
