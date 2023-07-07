using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abp.Domain.Entities.Auditing;
using Demotht.Models;
using NewProject.DbEntities;

namespace Demotht.DbEntities
{
    public class Book : FullAuditedEntity
    {
        [Required]
        [Display(Name = "Display Name")]
        [StringLength(64, ErrorMessage = "Maximum Length is 64")]
        public string Name { get; set; }
        public int? TotalPageNumber { get; set; }

        [ForeignKey("Author")]
        public int NameId { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Author Student { get; set; }
         
        public virtual Category Category { get; set; }


    }
}
