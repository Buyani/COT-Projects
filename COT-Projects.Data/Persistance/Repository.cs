using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace COT_Projects.Data.Persistance
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly COT_ProjectDataContext RepositoryContext;

        public Repository(COT_ProjectDataContext repositoryPatternDemoContext)
        {
            RepositoryContext = repositoryPatternDemoContext;
        }
        public IQueryable<TEntity> GetAll()
        {
            return RepositoryContext.Set<TEntity>();
        }
        public async Task AddAsync(TEntity entity)
        {
             await RepositoryContext.Set<TEntity>().AddAsync(entity);

        }
    }
}
