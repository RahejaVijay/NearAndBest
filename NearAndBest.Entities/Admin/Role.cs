using NearAndBest.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearAndBest.Entities.Admin
{
    public class Role : BaseEntity
    {
        public string RoleName { get; set; }

        public virtual ICollection<RoleFeature> Features { get; set; }
    }
}
