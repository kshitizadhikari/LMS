using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly ICustomerService _customerService;
        private readonly IFoodService _foodService;
        private readonly IMenuService _menuService;
        private readonly IMenuItemService _menuItemService;

        public ServiceWrapper(ICustomerService customerService, IFoodService foodService, IMenuService menuService, IMenuItemService menuItemService)
        {
            _customerService = customerService;
            _foodService = foodService;
            _menuService = menuService;
            _menuItemService = menuItemService;
        }
        public ICustomerService CustomerService => _customerService;
        public IFoodService FoodService => _foodService;
        public IMenuService MenuService => _menuService;
        public IMenuItemService MenuItemService => _menuItemService;
    }
}
