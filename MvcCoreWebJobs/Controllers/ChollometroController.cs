using Microsoft.AspNetCore.Mvc;
using MvcCoreWebJobs.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCoreWebJobs.Controllers
{
    public class ChollometroController : Controller
    {
        private RepositoryChollometro repo;

        public ChollometroController(RepositoryChollometro repo)
        {
            this.repo = repo;
        }

        public IActionResult Index()
        {
            return View(this.repo.GetChollos());
        }
    }
}
