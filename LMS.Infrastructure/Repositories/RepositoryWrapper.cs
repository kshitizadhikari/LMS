using LMS.Core.Interfaces;

namespace LMS.Infrastructure.Repositories
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
       private IPersonRepository _personRepository;

        public RepositoryWrapper(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }
        public IPersonRepository PersonRepository => _personRepository;

    }
}
