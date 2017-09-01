using System.Data.Common;
using Abp.Zero.EntityFramework;
using SamsonErp.Authorization.Roles;
using SamsonErp.Authorization.Users;
using SamsonErp.MultiTenancy;

namespace SamsonErp.EntityFramework
{
    public class SamsonErpDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public SamsonErpDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in SamsonErpDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of SamsonErpDbContext since ABP automatically handles it.
         */
        public SamsonErpDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public SamsonErpDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public SamsonErpDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
