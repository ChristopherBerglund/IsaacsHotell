using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using IsaacsHotell.Data;
using IsaacsHotell.Models;
using Microsoft.AspNetCore.Authorization;

namespace IsaacsHotell.Controllers
{
    public class RumsController : Controller
    {
        private readonly HotellDbContext _context;

        public RumsController(HotellDbContext context)
        {
            _context = context;
        }
        public IActionResult Städrapport()
        {

            var listasmutsigarum = _context.Bokningar.Where(x => x.Incheckning <= DateTime.Now && x.Utcheckning >= DateTime.Now).Include(x => x.Rum).Select(x => x.Rum).ToList();

            foreach (var rum in listasmutsigarum)
            {
                rum.Smutsigt = true;
                Console.WriteLine(rum.Id + " ");
            }
            _context.SaveChanges();

            Console.WriteLine();
            return RedirectToAction("städa", "Rums");

        }
        // GET: Rums
        [Authorize("Admin")]
        public async Task<IActionResult> Index()
        {
            return View(await _context.Rum.ToListAsync());
        }
        public async Task<IActionResult> Städa()
        {
            return View(await _context.Rum.ToListAsync());
        }

        public IActionResult Städaa(int _ID)
        {
            var städatrum = _context.Rum.Where(x => x.Id == _ID).Select(x => x).ToList();

            städatrum[0].Smutsigt = false;
            _context.SaveChanges();

            

            return RedirectToAction("städa", "Rums");
        }

        // GET: Rums/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rum = await _context.Rum
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rum == null)
            {
                return NotFound();
            }

            return View(rum);
        }

        // GET: Rums/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Rums/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Namn,Antalsovplatser,Smutsigt,BokningId")] Rum rum)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rum);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(rum);
        }

        // GET: Rums/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rum = await _context.Rum.FindAsync(id);
            if (rum == null)
            {
                return NotFound();
            }
            return View(rum);
        }

        // POST: Rums/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Namn,Antalsovplatser,Smutsigt,BokningId")] Rum rum)
        {
            if (id != rum.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rum);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RumExists(rum.Id))
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
            return View(rum);
        }

        // GET: Rums/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rum = await _context.Rum
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rum == null)
            {
                return NotFound();
            }

            return View(rum);
        }

        // POST: Rums/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rum = await _context.Rum.FindAsync(id);
            _context.Rum.Remove(rum);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RumExists(int id)
        {
            return _context.Rum.Any(e => e.Id == id);
        }
    }
}

