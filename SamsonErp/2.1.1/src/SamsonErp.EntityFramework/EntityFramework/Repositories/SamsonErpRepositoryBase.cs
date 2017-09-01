using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace SamsonErp.EntityFramework.Repositories
{
    public abstract class SamsonErpRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<SamsonErpDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected SamsonErpRepositoryBase(IDbContextProvider<SamsonErpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class SamsonErpRepositoryBase<TEntity> : SamsonErpRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected SamsonErpRepositoryBase(IDbContextProvider<SamsonErpDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
