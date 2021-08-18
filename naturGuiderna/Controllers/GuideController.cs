using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using naturGuiderna.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Controllers
{
    public class GuideController : Controller
    {
        private readonly NatureDbContext _context;


        public GuideController(NatureDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allGuides = await _context.Guides.ToListAsync();
            return View(allGuides);
        }
    }
}


