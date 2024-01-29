using Microsoft.AspNetCore.Mvc;
using TheMovieApi.Database;
using TheMovieApi.Models;

namespace TheMovieApi.Controllers
{
    /// <summary>
    ///  www.minsida.com/movies
    /// </summary>
    [Route("[controller]")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDbContext context;

        public MoviesController(MovieDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public ActionResult<List<Movie>> Get()
        {
            return context.Movies.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Movie?> Get(int id, [FromQuery] string title)
        {
            return context.Movies.FirstOrDefault(m => m.Id == id);
        }

        [HttpPost]
        public ActionResult Post(Movie movie)
        {
            context.Movies.Add(movie);
            context.SaveChanges();

            return Ok();
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            Movie? movieToDelete = context.Movies.FirstOrDefault(m => m.Id == id);

            if (movieToDelete != null)
            {
                context.Movies.Remove(movieToDelete);

                context.SaveChanges();

                return Ok();
            }

            return NotFound();
        }
    }
}
