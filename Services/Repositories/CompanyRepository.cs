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
            _db.AddComment(comment.Content).Execute(); //TODO: complete this method to include the rest of the information necessary to add a comment.
        }

        public IEnumerable<Comment> GetComments(int id)
        {
            var result = _db.GetComments(companyID: id).ExecuteTypedList<CommentDto>();
            return result.Select(c => new Comment { ID = c.ID, Content = c.Comment, CreatedOn = c.CreatedOn });
        }

        public IEnumerable<Company> GetCompanies() {
            var result = _db.GetCompanies().ExecuteTypedList<CompanyDto>();
            return result.Select(c => new Company { ID = c.ID, Name = c.Name, CreatedOn = c.CreatedOn});
        }
        
        private class CommentDto {

            public int ID { get; set; }
            public string Comment { get; set; }
            public int UserID { get; set; }
            public int ResponseID { get; set; }
            public DateTime CreatedOn { get; set; }
        }


        private class CompanyDto
        {
            public int ID { get; set; }
            public string Name { get; set; }
            public DateTime CreatedOn { get; set; }
        }



        YotaDB _db = new YotaDB();
    }
}
