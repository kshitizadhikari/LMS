using LMS.Core.Interfaces;

namespace LMS.Infrastructure
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ICustomerRepository _personRepository;
        private IFoodRepository _foodRepository;
        private IMenuRepository _menuRepository;
        private IMenuItemRepository _menuItemRepository;

        public RepositoryWrapper(ICustomerRepository personRepository, IFoodRepository foodRepository, IMenuRepository menuRepository, IMenuItemRepository menuItemRepository)
        {
            _personRepository = personRepository;
            _foodRepository = foodRepository;
            _menuRepository = menuRepository;
            _menuItemRepository = menuItemRepository;
        }
        public ICustomerRepository CustomerRepository => _personRepository;
        public IFoodRepository FoodRepository => _foodRepository;
        public IMenuRepository MenuRepository => _menuRepository;
        public IMenuItemRepository MenuItemRepository => _menuItemRepository;
    }
}
