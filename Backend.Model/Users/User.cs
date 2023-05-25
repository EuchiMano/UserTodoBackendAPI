using System.Text.Json.Serialization;

namespace Backend.Model.Users;

public class User : BaseEntity
{
	[JsonPropertyNameAttribute("name")]
	public string Name { get; set; }
	[JsonPropertyNameAttribute("username")]
	public string Username { get; set; }
	[JsonPropertyNameAttribute("email")]
	public string Email { get; set; }
	[JsonPropertyNameAttribute("password")]
	public string Password { get; set; }
	[JsonPropertyNameAttribute("website")]
	public string Website { get; set; }
}