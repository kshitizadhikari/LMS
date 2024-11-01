using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly ICustomerService _personService;
        public ServiceWrapper(ICustomerService personService)
        {
            _personService = personService;
        }
        public ICustomerService CustomerService => _personService;

    }
}
