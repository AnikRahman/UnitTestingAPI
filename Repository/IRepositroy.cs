using System.Linq.Expressions;

namespace UnitTestingAPI.Repository
{
	public interface IRepositroy<T> where T : class
	{

		T GetById(Guid id);
		IEnumerable<T> GetAll();
		IEnumerable<T> Find(Expression<Func<T, bool>> expression);
		void Add(T entity);
		void AddRange(IEnumerable<T> entities);
		void Remove(T entity);
		void RemoveRange(IEnumerable<T> entities);
		Task<T?> GetByIdAsync(Guid id);
		Task<IEnumerable<T>> GetAllAsync();
		Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression);
		Task AddAsync(T entity);
		Task AddRangeAsync(IEnumerable<T> entities);
		void Update(T entity);
		Task UpdateAsync(T entity);




	}
}
