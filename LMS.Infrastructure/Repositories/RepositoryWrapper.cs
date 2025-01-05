using LMS.Core.Interfaces;

namespace LMS.Infrastructure.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ICustomerRepository _personRepository;
        private IFoodRepository _foodRepository;
        private IMenuRepository _menuRepository;

        public RepositoryWrapper(ICustomerRepository personRepository, IFoodRepository foodRepository, IMenuRepository menuRepository)
        {
            _personRepository = personRepository;
            _foodRepository = foodRepository;
            _menuRepository = menuRepository;
        }
        public ICustomerRepository CustomerRepository => _personRepository;
        public IFoodRepository FoodRepository => _foodRepository;
        public IMenuRepository MenuRepository => _menuRepository;
    }
}
