using MoviesAPI.Data;
using System.Diagnostics.Eventing.Reader;

namespace MoviesAPI.Services
{
	public class MoviesServices
	{
		private AppDbContex _context;
		public MoviesServices(AppDbContex context)
		{
			_context = context;
		}
		public void AddMovie(MovieVM movie)
		{
			var newMovie = new Movie()
			{
				Name = movie.Name,
				Year = movie.Year,
				Genre = movie.Genre,

			};
			_context.Movies.Add(newMovie);
			_context.SaveChanges();
		}

		public List<Movie> GetAllMovies()
		{
			return _context.Movies.ToList();
		}
		public Movie GetMoviesById(int id)
		{
			return _context.Movies.FirstOrDefault(x => x.Id == id);
		}

		public Movie UpdateBookById(int id, MovieVM movieVM)
		{
			var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
			if (movie != null)
			{
				movie.Name = movieVM.Name;
				movie.Year = movieVM.Year;
				movie.Genre = movieVM.Genre;
				
				_context.SaveChanges();

			}

			return movie;

		}
		public void DeleteMovie(int id)
		{
			var movie = _context.Movies.FirstOrDefault(x => x.Id == id);
			_context.Movies.Remove(movie);
			_context.SaveChanges();
		}

	}
}
