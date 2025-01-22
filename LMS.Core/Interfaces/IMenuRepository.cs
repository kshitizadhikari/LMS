using LMS.Core.Entities;
using LMS.Core.Parameters;
using System.Linq.Expressions;

namespace LMS.Core.Interfaces
{
    public interface IMenuRepository: IBaseRepository<Menu>
    {
        Task<IList<Menu>> GetAllInclude(Expression<Func<Menu, bool>> expression, IncludeQP includeQP, MenuFP filter);
    }
}
