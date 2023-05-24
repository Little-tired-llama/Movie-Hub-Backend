using Microsoft.Extensions.Options;
using MongoDB.Driver;
using Movie_Hub_Backend.Models;

namespace Movie_Hub_Backend.Services
{
    public class MovieService
    {
        private readonly IMongoCollection<Movie> _movieCollection;

        public MovieService(IOptions<MovieHubDatabaseSettings> moviesDatabaseSettings)
        {
            var mongoDBClient = new MongoClient(moviesDatabaseSettings.Value.ConnectionString);
            var database = mongoDBClient.GetDatabase(moviesDatabaseSettings.Value.DatabaseName);
            _movieCollection = database.GetCollection<Movie>(moviesDatabaseSettings.Value.DatabaseName);
        }

        public async Task<List<Movie>> GetAllAsync()
        {
            return await _movieCollection.Find(_ => true).ToListAsync(); 
        }

        public async Task<Movie> GetByTitleAsync(string title)
        { 
            return await _movieCollection.Find(x => x.Title == title).FirstOrDefaultAsync();
        }
        public async Task CreateAsync(Movie movie)
        {
            await _movieCollection.InsertOneAsync(movie);
        }

        public async Task CreateDefaultAsync()
        {
            
            foreach (var mv in DefaultMoviesList.movies)
                await _movieCollection.InsertOneAsync(mv);
        }
        public async Task DeleteAsync(string title)
        { 
            await _movieCollection.DeleteOneAsync(x => x.Title == title);
        }

        public async Task UpdateAsync(string title, Movie newMovie)
        {
            await _movieCollection.ReplaceOneAsync(x => x.Title == title, newMovie);
        }
    }
}
