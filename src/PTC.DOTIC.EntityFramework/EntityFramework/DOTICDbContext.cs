using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using PTC.DOTIC.Authorization.Roles;
using PTC.DOTIC.Authorization.Users;
using PTC.DOTIC.Chat;
using PTC.DOTIC.Friendships;
using PTC.DOTIC.MultiTenancy;
using PTC.DOTIC.Storage;

namespace PTC.DOTIC.EntityFramework
{
    /* Constructors of this DbContext is important and each one has it's own use case.
     * - Default constructor is used by EF tooling on design time.
     * - constructor(nameOrConnectionString) is used by ABP on runtime.
     * - constructor(existingConnection) is used by unit tests.
     * - constructor(existingConnection,contextOwnsConnection) can be used by ABP if DbContextEfTransactionStrategy is used.
     * See http://www.aspnetboilerplate.com/Pages/Documents/EntityFramework-Integration for more.
     */

    public class DOTICDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        /* Define an IDbSet for each entity of the application */

        public virtual IDbSet<BinaryObject> BinaryObjects { get; set; }

        public virtual IDbSet<Friendship> Friendships { get; set; }

        public virtual IDbSet<ChatMessage> ChatMessages { get; set; }

        public DOTICDbContext()
            : base("Default")
        {
            
        }

        public DOTICDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        public DOTICDbContext(DbConnection existingConnection)
           : base(existingConnection, false)
        {

        }

        public DOTICDbContext(DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
