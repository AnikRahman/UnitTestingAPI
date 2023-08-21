using UnitTestingAPI.Context;

namespace UnitTestingAPI.Repository
{
	public class UnitOfWork : IUnitOfWork
	{
		private readonly ApplicationDbContext _dbContext;

		public UnitOfWork(ApplicationDbContext dbContext,
						  IAlicoClaimsRepository alicoClaimsRepository)
		{
			_dbContext = dbContext;
			AlicoClaimsRepository = alicoClaimsRepository;
		}

		public IAlicoClaimsRepository AlicoClaimsRepository { get; }

		public void BeginTransaction()
		{
			
		}

		public async Task BeginTransactionAsync(CancellationToken cancellationToken = default)
		{
			
			await Task.CompletedTask;
		}

		public void Commit()
		{
			_dbContext.SaveChanges();
		}

		public async Task CommitAsync(CancellationToken cancellationToken = default)
		{
			await _dbContext.SaveChangesAsync(cancellationToken);
		}

		public void Rollback()
		{
			
		}

		public async Task RollbackAsync(CancellationToken cancellationToken = default)
		{
	
			await Task.CompletedTask;
		}

		public void SaveAndCommit()
		{
			Commit();
		}

		public async Task SaveAndCommitAsync(CancellationToken cancellationToken = default)
		{
			await CommitAsync(cancellationToken);
		}

		public int SaveChanges()
		{
			return _dbContext.SaveChanges();
		}

		public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
		{
			return await _dbContext.SaveChangesAsync(cancellationToken);
		}

		public void Dispose()
		{
			_dbContext.Dispose();
		}
	}
}
