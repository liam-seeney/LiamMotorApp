using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiamMotorApp.Business.Repositories.Interfaces;

public interface IRepositoryBase<T> where T : class
{
  Task<T?> GetByIdAsync(Guid id);
  Task<IEnumerable<T>> GetAllAsync();
  void AddAsync(T entity);
  void UpdateAsync(T entity);
  void DeleteAsync(T entity);
  Task SaveChangesAsync();
}