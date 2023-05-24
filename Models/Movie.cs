using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Movie_Hub_Backend.Models
{
    public class Movie
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Title { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public int Rate { get; set; }
        public string Director { get; set; }
        public string[] Actors { get; set; }
        public string TeaserUrl { get; set; }
        public string PosterUrl { get; set; }
    }
}
