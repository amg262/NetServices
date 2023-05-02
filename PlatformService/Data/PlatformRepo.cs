using System.Collections.Generic;
using System.Linq;
using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _context;

        public PlatformRepo(AppDbContext context)
        {
            _context = context; // This is the database context that we created in AppDbContext.cs
        }

        public bool SaveChanges()
        {
            // If the changes are saved successfully, then the method will return true
            return (_context.SaveChanges() >= 0);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            // This will return all platforms
            return _context.Platforms.ToList();
        }

        public Platform GetPlatformById(int id)
        {
            //This will return a platform by its id (or null if it doesn't exist
            return _context.Platforms.FirstOrDefault(p => p.Id == id);

            //return _context.Platforms.Find(id); // This will return a platform by its id (or null if it doesn't exist
        }

        public void CreatePlatform(Platform plat)
        {
            if (plat == null)
            {
                throw new System.ArgumentNullException(nameof(plat));
            }

            _context.Platforms.Add(plat); // This will add a platform to the database
        }
    }
}