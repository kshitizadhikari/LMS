using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Infrastructure.Data;

namespace LMS.Infrastructure.Repositories
{
    public class CustomerRepository(AppDbContext dbContext) : BaseRepository<Customer>(dbContext), ICustomerRepository
    {
    }
}
