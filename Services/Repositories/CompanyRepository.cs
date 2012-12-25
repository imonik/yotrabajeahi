using Services.Interfaces;
using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;  
using System.Threading.Tasks;
using Yota.DataAccess;

namespace Services.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        public void AddComment(Comment comment)
        {
            _db.AddComment(comment.Content); //TODO: complete this method to include the rest of the information necessary to add a comment.
        }

        YotaDB _db = new YotaDB();
    }
}
