namespace LMS.Core.Services
{
    public interface IServiceWrapper
    {
        public ICustomerService CustomerService { get; }
        public IFoodService FoodService { get; }
        public IMenuService MenuService { get; }
        public IMenuItemService MenuItemService { get; }
    }
}
