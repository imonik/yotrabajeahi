using MvcApplication1.Models;
using Services.Interfaces;
using Services.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class CompaniesController : Controller
    {
        //
        // GET: /Companies/

        public ActionResult Index()
        {
            //var companies = new List<CompanyViewModel>();

            //companies.Add(new CompanyViewModel { Name = "Epicor Software Co. Ltd.", GeneralScore = 8.5m, CommentsCount = 15, ViewsCount = 53, ModifiedOn = new DateTime(2013, 1, 13, 15, 30, 20), ModifiedBy = "monik" });
            //companies.Add(new CompanyViewModel { Name = "Inflection Pont Systems", GeneralScore = 9.1m, CommentsCount = 52, ViewsCount = 47, ModifiedOn = new DateTime(2013, 1, 13, 18, 15, 20), ModifiedBy = "monik" });
            //companies.Add(new CompanyViewModel { Name = "Sieena software", GeneralScore = 8.9m, CommentsCount = 10, ViewsCount = 27, ModifiedOn = new DateTime(2013, 1, 13, 15, 30, 20), ModifiedBy = "fer" });
            //companies.Add(new CompanyViewModel { Name = "Venice Consulting Group Ltd.", GeneralScore = 9.4m, CommentsCount = 35, ViewsCount = 129, ModifiedOn = new DateTime(2013, 1, 13, 15, 30, 20), ModifiedBy = "someone" });

            var companies = _repo.GetCompanies();
            var vm = companies.Select(c => new CompanyViewModel {
                ID = c.ID,
                Name = c.Name,
                ModifiedOn = c.ModifiedOn,
                ModifiedBy = c.ModifiedBy,
                GeneralScore = (decimal)new Random(Seed: DateTime.Now.Second ^ c.ID).Next(5,11),
                CommentsCount = new Random(Seed: DateTime.Now.Second * c.ID).Next(0, 100),
                ViewsCount = new Random(Seed: DateTime.Now.Second * c.ID * c.ID + 1).Next(0, 100)
            });

            return View(vm);
        }

        ICompanyRepository _repo = new CompanyRepository();
    }
}
