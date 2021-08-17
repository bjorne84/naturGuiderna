using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using naturGuiderna.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace naturGuiderna.Controllers
{
    public class LocationController : Controller
    {
        private readonly NatureDbContext _context;
        public LocationController(NatureDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allGuides = await _context.Locations.ToListAsync();
            return View();
        }
    }
}
