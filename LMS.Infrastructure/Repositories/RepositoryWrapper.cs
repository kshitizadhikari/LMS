using LMS.Core.Interfaces;

namespace LMS.Infrastructure.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
       private ICustomerRepository _personRepository;

        public RepositoryWrapper(ICustomerRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public ICustomerRepository CustomerRepository => _personRepository;

    }
}
