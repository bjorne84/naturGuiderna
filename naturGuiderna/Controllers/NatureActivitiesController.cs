using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using naturGuiderna.Data;
using naturGuiderna.Models;

namespace naturGuiderna.Controllers
{
    public class NatureActivitiesController : Controller
    {
        private readonly NatureDbContext _context;

        public NatureActivitiesController(NatureDbContext context)
        {
            _context = context;
        }

        // GET: NatureActivities
        public async Task<IActionResult> Index()
        {
            var natureDbContext = _context.Activities.Include(n => n.Category).Include(n => n.Guide).Include(n => n.Location);
            return View(await natureDbContext.ToListAsync());
        }

        // GET: NatureActivities/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var natureActivity = await _context.Activities
                .Include(n => n.Category)
                .Include(n => n.Guide)
                .Include(n => n.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (natureActivity == null)
            {
                return NotFound();
            }

            return View(natureActivity);
        }

        // GET: NatureActivities/Create
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id");
            ViewData["GuideId"] = new SelectList(_context.Guides, "Id", "Id");
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id");
            return View();
        }

        // POST: NatureActivities/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,PictureUrl,Name,Description,Price,StartDate,EndDate,NumberOfParticipants,Availability,ActivityCategory,LocationId,GuideId,CategoryId")] NatureActivity natureActivity)
        {
            if (ModelState.IsValid)
            {
                _context.Add(natureActivity);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", natureActivity.CategoryId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "Id", "Id", natureActivity.GuideId);
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", natureActivity.LocationId);
            return View(natureActivity);
        }

        // GET: NatureActivities/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var natureActivity = await _context.Activities.FindAsync(id);
            if (natureActivity == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", natureActivity.CategoryId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "Id", "Id", natureActivity.GuideId);
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", natureActivity.LocationId);
            return View(natureActivity);
        }

        // POST: NatureActivities/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,PictureUrl,Name,Description,Price,StartDate,EndDate,NumberOfParticipants,Availability,ActivityCategory,LocationId,GuideId,CategoryId")] NatureActivity natureActivity)
        {
            if (id != natureActivity.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(natureActivity);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!NatureActivityExists(natureActivity.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "Id", "Id", natureActivity.CategoryId);
            ViewData["GuideId"] = new SelectList(_context.Guides, "Id", "Id", natureActivity.GuideId);
            ViewData["LocationId"] = new SelectList(_context.Locations, "Id", "Id", natureActivity.LocationId);
            return View(natureActivity);
        }

        // GET: NatureActivities/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var natureActivity = await _context.Activities
                .Include(n => n.Category)
                .Include(n => n.Guide)
                .Include(n => n.Location)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (natureActivity == null)
            {
                return NotFound();
            }

            return View(natureActivity);
        }

        // POST: NatureActivities/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var natureActivity = await _context.Activities.FindAsync(id);
            _context.Activities.Remove(natureActivity);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool NatureActivityExists(int id)
        {
            return _context.Activities.Any(e => e.Id == id);
        }
    }
}
