namespace Movie_Hub_Backend.Models
{
    public class MovieHubDatabaseSettings
    {
        public string ConnectionString { get; set; } = null!;
        public string DatabaseName { get; set; } = null!;
        public string MoviesCollectionName { get; set; } = null!;
    }
}
