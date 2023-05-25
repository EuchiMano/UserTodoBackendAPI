using System.Text.Json.Serialization;

namespace Backend.Model.Todos;

public class Todo : BaseEntity
{
	[JsonPropertyNameAttribute("userId")] public int UserId { get; set; }

	[JsonPropertyNameAttribute("title")] public string Title { get; set; }

	[JsonPropertyNameAttribute("completed")]
	public bool Completed { get; set; }
}