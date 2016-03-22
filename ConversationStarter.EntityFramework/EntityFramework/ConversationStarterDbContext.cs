using System.Data.Common;
using Abp.Zero.EntityFramework;
using ConversationStarter.Authorization.Roles;
using ConversationStarter.MultiTenancy;
using ConversationStarter.Users;

namespace ConversationStarter.EntityFramework
{
    public class ConversationStarterDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public ConversationStarterDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ConversationStarterDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ConversationStarterDbContext since ABP automatically handles it.
         */
        public ConversationStarterDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ConversationStarterDbContext(DbConnection connection)
            : base(connection, true)
        {

        }
    }
}
