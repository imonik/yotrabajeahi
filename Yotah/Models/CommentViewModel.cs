using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcApplication1.Models
{
    public class CommentViewModel
    {
        [Required]
        public string Comment { get; set; }
    }
}