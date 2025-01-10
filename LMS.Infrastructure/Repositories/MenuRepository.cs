﻿using LMS.Core.Entities;
using LMS.Core.Interfaces;
using LMS.Core.Parameters;
using LMS.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace LMS.Infrastructure.Repositories
{
    public class MenuRepository (AppDbContext dbContext): BaseRepository<Menu>(dbContext), IMenuRepository
    {

        public async Task<IList<Menu>> GetAllInclude(Expression<Func<Menu, bool>> expression, IncludeQP includeQP)
        {
            var query = BuildQuery(includeQP);
            query = query.Where(expression);
            return await query.ToListAsync();
        }

        private IQueryable<Menu> BuildQuery(IncludeQP includeQP)
        {
            IQueryable<Menu> query = DbSet;
            if (includeQP != null)
            {
                if (includeQP.MenuItems == true && includeQP.Foods == true)
                {
                    query = query.Include(x => x.MenuItems).ThenInclude(y => y.Food);
                }
                else if (includeQP.MenuItems == true)
                {
                    query = query.Include(x => x.MenuItems);
                }
            }
            return query;
        }
    }
}
