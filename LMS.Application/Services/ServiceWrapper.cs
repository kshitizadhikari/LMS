using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly ICustomerService _customerService;
        private readonly IFoodService _foodService;
        public ServiceWrapper(ICustomerService customerService, IFoodService foodService)
        {
            _customerService = customerService;
            _foodService = foodService;
        }
        public ICustomerService CustomerService => _customerService;
        public IFoodService FoodService => _foodService;

    }
}
