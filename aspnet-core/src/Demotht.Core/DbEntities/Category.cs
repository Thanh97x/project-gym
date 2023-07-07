using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using Demotht.DbEntities;

namespace Demotht.Models
{
    public class Category : FullAuditedEntity, IMayHaveTenant
    {

        [Required]
        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "Maximum Length is 64")]
        public string Name { get; set; }
        public int? TenantId { get ; set ; }
        public virtual ICollection<Book> Books { get; set; }
    }
}
