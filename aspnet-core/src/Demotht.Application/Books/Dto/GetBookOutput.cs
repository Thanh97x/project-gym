using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Demotht.DbEntities;
using Demotht.Models;
using System.Xml.Linq;

namespace Demotht.Books.Dto
{
    public class GetBookOutput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.Nullable<int> TotalPageNumber { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
