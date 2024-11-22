namespace LMS.Core.Services
{
    public interface IServiceWrapper
    {
        public ICustomerService CustomerService { get; }
        public IFoodService FoodService { get; }
    }
}
