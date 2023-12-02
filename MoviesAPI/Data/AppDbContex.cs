using Microsoft.EntityFrameworkCore;
using System;

namespace MoviesAPI.Data
{
	public class AppDbContex:DbContext
	{
		public AppDbContex(DbContextOptions<AppDbContex> options) : base(options) { }

		public DbSet<Movie> Movies { get; set; }
		
	}
}
