using LMS.Core.Interfaces;

namespace LMS.Infrastructure.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
       private ICustomerRepository _personRepository;
        private IFoodRepository _foodRepository;

        public RepositoryWrapper(ICustomerRepository personRepository, IFoodRepository foodRepository)
        {
            _personRepository = personRepository;
            _foodRepository = foodRepository;
        }
        public ICustomerRepository CustomerRepository => _personRepository;
        public IFoodRepository FoodRepository => _foodRepository;

    }
}
