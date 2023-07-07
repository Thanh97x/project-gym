using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace NewProject.DbEntities
{

    public class Student : FullAuditedEntity<long>, IMayHaveTenant
    {
        public int? TenantId { get ; set ; }
        public string Name { get; set; }
        public int? Age { get; set; }
        public string Class { get; set; }

    }

    
}
