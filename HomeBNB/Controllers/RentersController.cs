using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HomeBnB.Models;

namespace HomeBnB.Controllers
{
    public class RentersController : Controller
    {
        private readonly HomeBnBContext _context;

        public RentersController(HomeBnBContext context)
        {
            _context = context;
        }

        // GET: Renters
        public async Task<IActionResult> Index()
        {
            return View(await _context.Renter.ToListAsync());
        }

        // GET: Renters/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var renter = await _context.Renter
                .FirstOrDefaultAsync(m => m.RenterID == id);
            if (renter == null)
            {
                return NotFound();
            }

            return View(renter);
        }

        // GET: Renters/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Renters/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RenterID,RenterName,RenterEmail")] Renter renter)
        {
            if (ModelState.IsValid)
            {
                _context.Add(renter);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(renter);
        }

        // GET: Renters/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var renter = await _context.Renter.FindAsync(id);
            if (renter == null)
            {
                return NotFound();
            }
            return View(renter);
        }

        // POST: Renters/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RenterID,RenterName,RenterEmail")] Renter renter)
        {
            if (id != renter.RenterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(renter);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RenterExists(renter.RenterID))
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
            return View(renter);
        }

        // GET: Renters/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var renter = await _context.Renter
                .FirstOrDefaultAsync(m => m.RenterID == id);
            if (renter == null)
            {
                return NotFound();
            }

            return View(renter);
        }

        // POST: Renters/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var renter = await _context.Renter.FindAsync(id);
            _context.Renter.Remove(renter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RenterExists(int id)
        {
            return _context.Renter.Any(e => e.RenterID == id);
        }
    }
}
