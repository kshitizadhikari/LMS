using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;

namespace LMS.Infrastructure.Repositories
{
    public class MenuItemRepository (AppDbContext dbContext): BaseRepository<MenuItem>(dbContext), IMenuItemRepository
    {
    }
}
