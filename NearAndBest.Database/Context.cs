using NearAndBest.Entities.Admin;
using NearAndBest.Entities.Master;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearAndBest.Database
{
    public class NearAndBestContext : DbContext,IDisposable
    {
        #region Admin   
        public DbSet<Role> Roles { get; set; }

        public DbSet<FeaturePermission> FeaturePermissions { get; set; }

        public DbSet<RoleFeature> RoleFeatues { get; set; }

        public DbSet<User> Users { get; set; }

        
        #endregion

        #region Master

        public DbSet<Feature> Features { get; set; }
        public DbSet<Permission> Permissions { get; set; }

        #endregion

        #region ctor
        public NearAndBestContext()
            : base("Name=NearAndBestContext")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
            Configuration.AutoDetectChangesEnabled = true;
            this.Database.CreateIfNotExists();

        }

        #endregion

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }
    }
}
