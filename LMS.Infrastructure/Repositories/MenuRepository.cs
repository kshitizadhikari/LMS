using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;

namespace LMS.Infrastructure.Repositories
{
    public class MenuRepository (AppDbContext dbContext): BaseRepository<Menu>(dbContext), IMenuRepository
    {
    }
}
