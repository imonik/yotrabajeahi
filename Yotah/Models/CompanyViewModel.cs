using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CompanyViewModel
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; }
        public decimal GeneralScore { get; set; }
        public int CommentsCount { get; set; }
        public int ViewsCount { get; set; }
    }
}