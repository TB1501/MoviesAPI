using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MoviesAPI.Data;
using MoviesAPI.Services;

namespace MoviesAPI.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class MoviesController : ControllerBase
	{
		public MoviesServices MoviesServices { get; set; }
		public MoviesController(MoviesServices moviesService)
		{
			MoviesServices = moviesService;
		}

		[HttpPost]
		public IActionResult AddMovie([FromBody] MovieVM movie)
		{
			MoviesServices.AddMovie(movie);
			return Ok();
		}
		[HttpGet]
		public IActionResult GetAllMovies()
		{
			var allMovies = MoviesServices.GetAllMovies();
			return Ok(allMovies);
		}


		[HttpGet("id")]
		public IActionResult GetMovieById([FromQuery] int id)
		{
			var movie = MoviesServices.GetMoviesById;
			return Ok(movie);
		}

		[HttpDelete("id")]
		public IActionResult DeleteMovie([FromQuery] int id)
		{
			MoviesServices.DeleteMovie(id);
			return Ok();
		}




	}
}

