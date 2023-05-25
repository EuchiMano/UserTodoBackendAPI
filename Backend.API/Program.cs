using System.Text;
using Backend.API.Models;
using Backend.API.Services;
using Backend.API.Services.Users;
using Backend.DataAccess.Data;
using Backend.DataAccess.Repositories;
using Backend.Model.Interfaces;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
{
	builder.Services.AddScoped<AuthTokenService>();
	builder.Services.AddTransient<UserService>();
	builder.Services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
	builder.Services.AddTransient<IUserRepository, UserRepository>();
	builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection(nameof(JwtSettings)));
	var jwtSettings = new JwtSettings();
	builder.Configuration.Bind(nameof(JwtSettings), jwtSettings);

	builder.Services.AddAuthentication(auth =>
		{
			auth.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
			auth.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
		})
		.AddJwtBearer(options =>
		{
			options.SaveToken = true;
			options.TokenValidationParameters = new TokenValidationParameters
			{
				ValidateIssuer = true,
				ValidIssuer = jwtSettings.Issuer,
				ValidateAudience = true,
				ValidAudience = jwtSettings.Audience,
				ValidateIssuerSigningKey = true,
				IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SigningKey))
			};
		});
	builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console());
	builder.Services.AddSwaggerGen();
	builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(
		builder.Configuration.GetConnectionString("DefaultConnection")));

	builder.Services.AddControllers();
}
var app = builder.Build();
{
	app.UseSerilogRequestLogging();
	app.MapGet("/", () => "Ghetto JWT / Training");

	app.UseAuthentication();
	app.UseAuthorization();
	app.UseSwagger();
	app.UseSwaggerUI();
	app.MapControllers();
}
app.Run();