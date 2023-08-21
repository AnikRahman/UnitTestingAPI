﻿using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using UnitTestingAPI.Context;

namespace UnitTestingAPI.Repository
{
	public class Repository<T> : IRepositroy<T> where T : class
	{

		protected readonly ApplicationDbContext _context;
		public Repository(ApplicationDbContext context)
		{
			_context = context;
		}
		public void Add(T entity)
		{
			_context.Set<T>().Add(entity);
		}

		public void AddRange(IEnumerable<T> entities)
		{
			_context.Set<T>().AddRange(entities);
		}

		public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
		{
			return _context.Set<T>().Where(expression);
		}

		public IEnumerable<T> GetAll()
		{
			return _context.Set<T>().ToList();
		}


		public T GetById(Guid id)
		{
			return _context.Set<T>().Find(id)!;
		}

		public void Remove(T entity)
		{
			_context.Set<T>().Remove(entity);
		}

		public void RemoveRange(IEnumerable<T> entities)
		{
			_context.Set<T>().RemoveRange(entities);
		}

		public async Task AddAsync(T entity)
		{
			await _context.Set<T>().AddAsync(entity);
		}

		public async Task AddRangeAsync(IEnumerable<T> entities)
		{
			await _context.Set<T>().AddRangeAsync(entities);
		}

		public async Task<IEnumerable<T>> FindAsync(Expression<Func<T, bool>> expression)
		{
			return await _context.Set<T>().Where(expression).ToListAsync();
		}

		public async Task<IEnumerable<T>> GetAllAsync()
		{
			return await _context.Set<T>().ToListAsync();
		}

		public async Task<T?> GetByIdAsync(Guid id)
		{
			return await _context.Set<T>().FindAsync(id);
		}

		public void Update(T entity)
		{
			_context.Set<T>().Update(entity);
		}

		public async Task UpdateAsync(T entity)
		{
			_context.Set<T>().Update(entity);
			await _context.SaveChangesAsync();
		}
	}
}
