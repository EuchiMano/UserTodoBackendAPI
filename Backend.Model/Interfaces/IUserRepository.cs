using Backend.Model.Todos;
using Backend.Model.Users;

namespace Backend.Model.Interfaces
{
	public interface IUserRepository : IGenericRepository<User>
	{
		bool CheckEmailAndPassAsync(string email, string password);
		Task<IEnumerable<Todo>> GetAllTodosByUserIdAsync(int userId);
		Task<Todo> GetTodoByUserAndTodoIdAsync(int userId, int todoId);
	}
}
