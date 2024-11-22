using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;

namespace LMS.Infrastructure.Repositories
{
    public class FoodRepository(AppDbContext dbContext) : BaseRepository<Food>(dbContext), IFoodRepository
    {
    }
}
