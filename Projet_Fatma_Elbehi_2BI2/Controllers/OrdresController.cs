using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Projet_Fatma_Elbehi_2BI2.Data;
using Projet_Fatma_Elbehi_2BI2.Models;

namespace Projet_Fatma_Elbehi_2BI2.Controllers
{
    public class OrdresController : Controller
    {
        private readonly Projet_Fatma_Elbehi_2BI2Context _context;

        public OrdresController(Projet_Fatma_Elbehi_2BI2Context context)
        {
            _context = context;
        }

        // GET: Ordres
        public async Task<IActionResult> Index()
        {
            var projet_Fatma_Elbehi_2BI2Context = _context.Ordres.Include(o => o.Client);
            return View(await projet_Fatma_Elbehi_2BI2Context.ToListAsync());
        }

        // GET: Ordres/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordres = await _context.Ordres
                .Include(o => o.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordres == null)
            {
                return NotFound();
            }

            return View(ordres);
        }

        // GET: Ordres/Create
        public IActionResult Create()
        {
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id");
            return View();
        }

        // POST: Ordres/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,prix,ProduitId,ClientId")] Ordres ordres)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordres);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", ordres.ClientId);
            return View(ordres);
        }

        // GET: Ordres/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordres = await _context.Ordres.FindAsync(id);
            if (ordres == null)
            {
                return NotFound();
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", ordres.ClientId);
            return View(ordres);
        }

        // POST: Ordres/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,prix,ProduitId,ClientId")] Ordres ordres)
        {
            if (id != ordres.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordres);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdresExists(ordres.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", ordres.ClientId);
            return View(ordres);
        }

        // GET: Ordres/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordres = await _context.Ordres
                .Include(o => o.Client)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (ordres == null)
            {
                return NotFound();
            }

            return View(ordres);
        }

        // POST: Ordres/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordres = await _context.Ordres.FindAsync(id);
            _context.Ordres.Remove(ordres);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdresExists(int id)
        {
            return _context.Ordres.Any(e => e.Id == id);
        }
    }
}
