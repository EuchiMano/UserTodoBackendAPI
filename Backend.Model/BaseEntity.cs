using System.Text.Json;
using System.Text.Json.Serialization;

namespace Backend.Model
{
	public abstract class BaseEntity
	{
		[JsonPropertyNameAttribute("id")]
		public int Id { get; set; }
	}
}
