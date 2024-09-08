using LMS.Core.Interfaces;
using LMS.Core.Services;

namespace LMS.Application.Services
{
    public class ServiceWrapper : IServiceWrapper
    {
        private readonly IPersonService _personService;
        public ServiceWrapper(IPersonService personService)
        {
            _personService = personService;
        }
        public IPersonService PersonService => _personService;

    }
}
