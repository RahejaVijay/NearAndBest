using NearAndBest.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NearAndBest.Entities.Admin
{
    public class FeaturePermission : BaseEntity
    {
        public virtual int FeatureId { get; set; }
    }
}
