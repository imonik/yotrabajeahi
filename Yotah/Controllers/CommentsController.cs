using MvcApplication1.Models;
using Services.Interfaces;
using Services.Models;
using Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CommentsController : Controller
    {
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(CommentViewModel vm)
        {
            if (!ModelState.IsValid)
            {
                return View(vm);
            }

            var comment = new Comment { Content = vm.Comment, CreatedOn = DateTime.UtcNow };
            _repo.AddComment(comment);

            return View(); // TODO: We should show the new commment on the companie's details page.
        }

        ICompanyRepository _repo = new CompanyRepository();
    }
}
