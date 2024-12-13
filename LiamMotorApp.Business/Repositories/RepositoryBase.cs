using LiamMotorApp.Business.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiamMotorApp.Business.Repositories;

public class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
  private readonly DbContext _context;
  private protected readonly DbSet<T> _dbSet;

  public RepositoryBase(DatabaseContext context)
  {
    _context = context;
    _dbSet = _context.Set<T>();
  }

  public async Task<IEnumerable<T>> GetAllAsync() => await _dbSet.ToListAsync();

  public async Task<T?> GetByIdAsync(Guid id) => await _dbSet.FindAsync(id);

  public void AddAsync(T entity) => _dbSet.Add(entity);

  public void UpdateAsync(T entity) => _dbSet.Update(entity);

  public void DeleteAsync(T entity) => _dbSet.Remove(entity);

  public async Task SaveChangesAsync() => await _context.SaveChangesAsync();
}
