using NearAndBest.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearAndBest.Entities.Admin
{
    public class RoleFeature  :BaseEntity
    {
        public virtual int RoleId { get; set; }

        public virtual ICollection<FeaturePermission> Permissions { get; set; }
    }
}
