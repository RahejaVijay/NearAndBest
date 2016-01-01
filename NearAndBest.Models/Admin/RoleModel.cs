namespace NearAndBest.Models.Admin
{
    using Models.Common;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    
    public class RoleModel : BaseModel
    {
        [Required]
        public string RoleName { get; set; }

        public virtual ICollection<RoleFeatureModel> Features { get; set; }
    }
}