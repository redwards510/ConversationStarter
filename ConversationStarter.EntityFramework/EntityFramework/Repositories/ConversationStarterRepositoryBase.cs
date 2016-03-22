using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace ConversationStarter.EntityFramework.Repositories
{
    public abstract class ConversationStarterRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<ConversationStarterDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected ConversationStarterRepositoryBase(IDbContextProvider<ConversationStarterDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class ConversationStarterRepositoryBase<TEntity> : ConversationStarterRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected ConversationStarterRepositoryBase(IDbContextProvider<ConversationStarterDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
