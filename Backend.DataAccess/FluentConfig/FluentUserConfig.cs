using Backend.Model.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Backend.DataAccess.FluentConfig;

public class FluentUserConfig : IEntityTypeConfiguration<User>
{
	public void Configure(EntityTypeBuilder<User> builder)
	{
		//builder.HasKey(u => u.Id);
		builder.Property(u => u.Email).IsRequired().HasMaxLength(50);
		builder.Property(u => u.Password).HasMaxLength(8);
		//builder.Property(u => u.Name);
		//builder.Property(u => u.Username);
		//builder.Property(u => u.Website);
		builder.HasData(SeedData.Users());
	}
}