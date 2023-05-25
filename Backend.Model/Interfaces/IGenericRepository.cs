namespace Backend.Model.Interfaces;

public interface IGenericRepository<T> where T : BaseEntity
{
	Task<IEnumerable<T>> GetAllAsync();
	Task<T> GetByIdAsync(int id);
}