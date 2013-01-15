using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Models
{
    public class Company
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreatedOn { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string CreatedBy { get; set; } // TODO: This property has to be changed from a 'string' to a 'User' model.
        public string ModifiedBy { get; set; } // TODO: This property has to be changed from a 'string' to a 'User' model.
    }
}
