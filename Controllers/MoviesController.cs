using Microsoft.AspNetCore.Mvc;

namespace Movie_Hub_Backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {

        private readonly ILogger<MoviesController> _logger;

        public MoviesController(ILogger<MoviesController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Movie> GetAll()
        {
            return null;
        }
    }
}