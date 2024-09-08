using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;

namespace LMS.Infrastructure.Repositories
{
    public class PersonRepository(AppDbContext dbContext) : BaseRepository<Person>(dbContext), IPersonRepository
    {
    }
}
