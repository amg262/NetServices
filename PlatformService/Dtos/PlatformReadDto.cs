namespace PlatformService.Dtos
{
    // This could also MAYBE be a record but we wont for now
    public class PlatformReadDto // record type - more appropriate for (DTOs) and this instance but Records are immutable
    {
        public int Id { get; set; }
        
        public string Name { get; set; }
        
        public string Publisher { get; set; }
        
        public string Cost { get; set; }
    }
}