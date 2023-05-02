using System;
using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using PlatformService.Models;

namespace PlatformService.Data
{
    public static class PrepDb
    {
        // Seed data
        public static void PrepPopulation(IApplicationBuilder app)
        {
            using (var serviceScope = app.ApplicationServices.CreateScope()) // Create a scope
            {
                SeedData(serviceScope.ServiceProvider
                    .GetService<AppDbContext>()); // Get the service from the scope and pass it to the SeedData method
            }
        }

        // Seed data
        private static void SeedData(AppDbContext context)
        {
            if (!context.Platforms.Any()) // If there are no platforms in the database
            {
                Console.WriteLine("--> Seeding data..."); // Write to the console
                context.Platforms.AddRange( // Add a range of platforms to the database
                    new Platform()
                        {Name = "Dot Net", Publisher = "Microsoft", Cost = "Free"},
                    new Platform()
                        {Name = "SQL Server Express", Publisher = "Microsoft", Cost = "Free"},
                    new Platform()
                        {Name = "Kubernetes", Publisher = "Cloud Native Computing Foundation", Cost = "Free"}
                );
                context.SaveChanges(); // Save the changes
            }
            else
            {
                Console.WriteLine("--> We already have data"); // Write to the console
            }
        }
    }
}