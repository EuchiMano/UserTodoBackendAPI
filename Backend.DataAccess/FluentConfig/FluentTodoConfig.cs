using Backend.Model.Todos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.DataAccess.FluentConfig;

public class FluentTodoConfig : IEntityTypeConfiguration<Todo>
{
	public void Configure(EntityTypeBuilder<Todo> builder)
	{
		builder.HasData(SeedData.Todos());
	}
}