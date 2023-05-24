﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Text.Json.Serialization;

namespace Movie_Hub_Backend.Models
{
    public class Movie
    {
        [BsonId]
        [BsonElement("Title")]
        [JsonPropertyName("Title")]
        public string Title { get; set; }

        [JsonPropertyName("Description")]
        public string Description { get; set; }
        public int Year { get; set; }
        public int Rate { get; set; }

        [JsonPropertyName("Director")]
        public string Director { get; set; }
        public string[] Actors { get; set; }

        [JsonPropertyName("TeaserUrl")]
        public string TeaserUrl { get; set; }

        [JsonPropertyName("PosterUrl")]
        public string PosterUrl { get; set; }
    }
}
