namespace LMS.Core.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task<T> CreateAsync(T entity);
        Task UpdateAsysnc(T entity);
        Task<bool> DeleteAsync(string id);
        Task<T> GetById(string id);
        Task<IEnumerable<T>> GetAllAsync();
    }
}
