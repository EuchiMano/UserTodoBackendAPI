using Backend.DataAccess.Data;
using Backend.Model.Interfaces;
using Backend.Model.Todos;
using Backend.Model.Users;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Repositories;

public class UserRepository : GenericRepository<User>, IUserRepository
{
	public UserRepository(ApplicationDbContext context) : base(context)
	{
	}

	public bool CheckEmailAndPassAsync(string email, string password)
	{
		var userFound = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
		return userFound is not null;
	}

	public async Task<IEnumerable<Todo>> GetAllTodosByUserIdAsync(int userId)
	{
		return await _context.Todos
			.Where(t => t.UserId == userId)
			.ToListAsync();
	}

	public async Task<Todo> GetTodoByUserAndTodoIdAsync(int userId, int todoId)
	{
		return await _context.Todos
			.Where(t => t.Id == todoId && t.UserId == userId).FirstOrDefaultAsync();
	}
}