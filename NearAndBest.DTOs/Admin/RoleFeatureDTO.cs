using NearAndBest.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearAndBest.DTOs.Admin
{
    public class RoleFeatureDTO  :BaseDTO
    {
        public virtual int RoleId { get; set; }

        public virtual ICollection<FeaturePermissionDTO> Permissions { get; set; }
    }
}
