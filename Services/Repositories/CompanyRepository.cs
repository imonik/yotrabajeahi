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
            var result = new List<Company>();
            result.Add(new Company { ID = 1, Name = "Epicor Software Co. Ltd.", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, CreatedBy = "monik", ModifiedBy = "monik" });
            result.Add(new Company { ID = 2, Name = "Inflection Pont Systems", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, CreatedBy = "monik", ModifiedBy = "monik" });
            result.Add(new Company { ID = 3, Name = "Sieena software", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, CreatedBy = "monik", ModifiedBy = "fer" });
            result.Add(new Company { ID = 4, Name = "Venice Consulting Group Ltd.", CreatedOn = DateTime.Now, ModifiedOn = DateTime.Now, CreatedBy = "monik", ModifiedBy = "someone" });

            return result;
        }

        private class CommentDto {
            public int ID { get; set; }
            public string Comment { get; set; }
            public int UserID { get; set; }
            public int ResponseID { get; set; }
            public DateTime CreatedOn { get; set; }
        }

        YotaDB _db = new YotaDB();
    }
}
