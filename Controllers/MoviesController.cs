using Microsoft.AspNetCore.Mvc;
using Movie_Hub_Backend.Models;
using Movie_Hub_Backend.Services;

namespace Movie_Hub_Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieService _movieService;

        public MoviesController(MovieService movieService) => _movieService = movieService;

        [HttpGet]
        [Route("/GetAll")]
        public async Task<IEnumerable<Movie>> GetAll()
        {
            return await _movieService.GetAllAsync();
        }

        [HttpGet]
        [Route("/GetByTitle/{title}")]
        public async Task<Movie> GetByTitle(string title)
        {
            return await _movieService.GetByTitleAsync(title);
        }

        [HttpPost]
        [Route("/Create")]
        public async Task CreateMovie(Movie movie)
        {
            await _movieService.CreateAsync(movie);
        }

        [HttpPost]
        [Route("/CreateDefault")]
        public async Task CreateDefaultMovies()
        {
            await _movieService.CreateDefaultAsync();
        }

        [HttpPut]
        [Route("/Update")]
        public async Task UpdateMovie(string title, Movie newMovie)
        { 
            await _movieService.UpdateAsync(title, newMovie);
        }

        [HttpDelete]
        [Route("/Delete")]
        public async Task DeleteMovie(string title)
        { 
            await _movieService.DeleteAsync(title);
        }
    }
}