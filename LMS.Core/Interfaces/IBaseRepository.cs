﻿namespace LMS.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task UpdateAsync(T entity);
        Task<bool> DeleteAsync(Guid id);
        Task<T?> GetByIdAsync(Guid id);
        Task<IList<T>> GetAllAsync();
    }
}
