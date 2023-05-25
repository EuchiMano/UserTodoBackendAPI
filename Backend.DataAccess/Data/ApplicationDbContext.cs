using Backend.DataAccess.FluentConfig;
using Backend.Model.Todos;
using Backend.Model.Users;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Data;

public class ApplicationDbContext : DbContext
{
	public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
	{
	}

	public DbSet<User> Users { get; set; }

	public DbSet<Todo> Todos { get; set; }

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		base.OnModelCreating(modelBuilder);
		modelBuilder.ApplyConfiguration(new FluentUserConfig());
		modelBuilder.ApplyConfiguration(new FluentTodoConfig());
	}
}