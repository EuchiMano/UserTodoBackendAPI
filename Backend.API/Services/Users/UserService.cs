using Backend.Model.Interfaces;
using Backend.Model.Todos;
using Backend.Model.Users;

namespace Backend.API.Services.Users;

public class UserService
{
	private readonly IUserRepository _userRepository;

	public UserService(IUserRepository userRepository)
	{
		_userRepository = userRepository;
	}

	public async Task<IEnumerable<User>> GetUsers()
	{
		return await _userRepository.GetAllAsync();
	}

	public async Task<User> GetUserById(int userId)
	{
		return await _userRepository.GetByIdAsync(userId);
	}

	public async Task<IEnumerable<Todo>> GetTodosByUserId(int userId)
	{
		if (!await UserExist(userId)) return null;
		var todosFound = await _userRepository.GetAllTodosByUserIdAsync(userId);
		return todosFound;
	}

	public async Task<Todo> GetTodoByUserAndTodoIdAsync(int userId, int todoId)
	{
		return await _userRepository.GetTodoByUserAndTodoIdAsync(userId, todoId);
	}

	private async Task<bool> UserExist(int userId)
	{
		var userFound = await _userRepository.GetByIdAsync(userId);
		return userFound is not null;
	}
}