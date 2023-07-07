using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demotht.Books.Dto
{
    public class UpdateBookInput
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public System.Nullable<int> TotalPageNumber { get; set; }
        public int AuthorId { get; set; }
        public int CategoryId { get; set; }
    }
}
