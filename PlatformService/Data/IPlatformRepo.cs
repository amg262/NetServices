using System.Collections;
using System.Collections.Generic;
using PlatformService.Models;

namespace PlatformService.Data
{
    public interface IPlatformRepo
    {
        bool SaveChanges(); // This method will return true if the changes were saved successfully
        IEnumerable<Platform> GetAllPlatforms(); // This method will return all platforms
        Platform GetPlatformById(int id); // This method will return a platform by its id
        void CreatePlatform(Platform plat); // This method will create a platform
    }
}