using NearAndBest.DTOs.Common;
using System.Collections.Generic;

namespace NearAndBest.DTOs.Admin
{
    // testing by Vijay
    public class RoleDTO : BaseDTO
    {
        public string RoleName { get; set; }

        public virtual ICollection<RoleFeatureDTO> Features { get; set; }
    }
}
