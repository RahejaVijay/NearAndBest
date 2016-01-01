

namespace NearAndBest.Models.Admin
{
    using Models.Common;
    using System.Collections.Generic;

    public class RoleFeatureModel : BaseModel
    {
        
        public  int RoleId { get; set; }

        public  ICollection<FeaturePermissionModel> Permissions { get; set; }
    }
}