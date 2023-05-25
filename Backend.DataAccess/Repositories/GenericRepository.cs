using Backend.DataAccess.Data;
using Backend.Model;
using Backend.Model.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Backend.DataAccess.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
	protected readonly ApplicationDbContext _context;

	public GenericRepository(ApplicationDbContext context)
	{
		_context = context;
	}

	public async Task<IEnumerable<T>> GetAllAsync()
	{
		return await _context.Set<T>().ToListAsync();
	}

	public async Task<T> GetByIdAsync(int id)
	{
		return await _context.Set<T>().AsNoTracking().FirstOrDefaultAsync(a => a.Id.Equals(id));
	}
}