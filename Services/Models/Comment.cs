using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Comment
    {
        public int ID { get; set; }
        public string Content { get; set; }
        public DateTime CreatedOn { get; set; }
        // TODO: add the rest of the properties: User, Company, etc.
    }
}
