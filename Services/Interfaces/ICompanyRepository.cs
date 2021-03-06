﻿using Services.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Interfaces
{
    public interface ICompanyRepository
    {
        void AddComment(Comment comment);
        IEnumerable<Comment> GetComments(int id);
        IEnumerable<Company> GetCompanies();
    }
}
