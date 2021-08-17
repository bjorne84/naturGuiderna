using Microsoft.AspNetCore.Mvc;
using naturGuiderna.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Controllers
{
    public class ExperiencesController : Controller
    {
        private readonly NatureDbContext _context;


        public ExperiencesController(NatureDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var data = _context.Experiences.ToList();
            return View();
        }
    }
}
