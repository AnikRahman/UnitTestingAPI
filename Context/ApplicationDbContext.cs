using Microsoft.EntityFrameworkCore;
using UnitTestingAPI.Domain;

namespace UnitTestingAPI.Context
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions options) : base(options)
		{
		}

		public DbSet<AlicoClaims> Claims { get; set; }
	}
}
