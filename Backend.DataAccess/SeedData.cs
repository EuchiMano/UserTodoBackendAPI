using System.Text.Json;
using Backend.Model.Todos;
using Backend.Model.Users;

namespace Backend.DataAccess;

public static class SeedData
{
	public static List<User> Users()
	{
		var usersJson = File.ReadAllText("test.json");

		var userList = JsonSerializer.Deserialize<List<User>>(usersJson);

		return userList;
	}

	public static List<Todo> Todos()
	{
		var todoJson = File.ReadAllText("testtodo.json");

		var todoList = JsonSerializer.Deserialize<List<Todo>>(todoJson);

		return todoList;
	}
}