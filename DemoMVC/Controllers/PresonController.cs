using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DemoMVC.Data;
using DemoMVC.Models;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace DemoMVC.Controllers
{
    public class PresonController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PresonController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Preson
    
       public async Task<IActionResult> Index()
        {
            return View(await _context.Preson.ToListAsync());
        }
        
        [HttpPost]
        public async Task<IActionResult> Index(string tuKhoa)
        {
            return View(await _context.Preson.Where(s => s.FullName.Contains(tuKhoa)).ToListAsync());
        }



        // GET: Preson/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preson = await _context.Preson
                .FirstOrDefaultAsync(m => m.PresonId == id);
            if (preson == null)
            {
                return NotFound();
            }

            return View(preson);
        }

        // GET: Preson/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Preson/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PresonId,FullName,Address")] Preson preson)
        {
            if (ModelState.IsValid)
            {
                _context.Add(preson);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(preson);
        }

        // GET: Preson/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preson = await _context.Preson.FindAsync(id);
            if (preson == null)
            {
                return NotFound();
            }
            return View(preson);
        }

        // POST: Preson/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PresonId,FullName,Address")] Preson preson)
        {
            if (id != preson.PresonId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(preson);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PresonExists(preson.PresonId))
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
            return View(preson);
        }

        // GET: Preson/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var preson = await _context.Preson
                .FirstOrDefaultAsync(m => m.PresonId == id);
            if (preson == null)
            {
                return NotFound();
            }

            return View(preson);
        }

        // POST: Preson/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var preson = await _context.Preson.FindAsync(id);
            if (preson != null)
            {
                _context.Preson.Remove(preson);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PresonExists(string id)
        {
            return _context.Preson.Any(e => e.PresonId == id);
        }
    }
}
