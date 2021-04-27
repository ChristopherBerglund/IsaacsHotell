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
using Microsoft.AspNetCore.Identity;

namespace IsaacsHotell.Controllers
{
    [Authorize]
    public class BokningsController : Controller
    {
        private readonly HotellDbContext _context;
        private readonly UserManager<Användare> _userManager;
        private readonly SignInManager<Användare> _signInManager;

        public BokningsController(HotellDbContext context, UserManager<Användare> userManager, SignInManager<Användare> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET: Boknings
        public async Task<IActionResult> Index()
        {
            var hotellDbContext = _context.Bokningar.Include(b => b.Gäst).Include(b => b.Rum);
            return View(await hotellDbContext.ToListAsync());
        }

        // GET: Boknings/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bokning = await _context.Bokningar
                .Include(b => b.Gäst)
                .Include(b => b.Rum)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bokning == null)
            {
                return NotFound();
            }

            return View(bokning);
        }

        // GET: Boknings/Create
        public IActionResult Create()
        {
            ViewData["GästId"] = new SelectList(_context.Gäster, "Id", "");
            ViewData["RumId"] = new SelectList(_context.Rum, "Id", "Id");
            return View();
        }

        // POST: Boknings/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Incheckning,Utcheckning,GästId,RumId")] Bokning bokning)
        {
            if (ModelState.IsValid) //kommer inte in här när jag försöker skapa. Nått med relationen i db som är fuckad
            {
                _context.Add(bokning);
                 //här kanske det måste uppdateras i Gästen också
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["GästId"] = new SelectList(_context.Gäster, "Id", "Id", bokning.GästId);
            ViewData["RumId"] = new SelectList(_context.Rum, "Id", "Id", bokning.RumId);
            return View(bokning);
        }

        // GET: Boknings/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bokning = await _context.Bokningar.FindAsync(id);
            if (bokning == null)
            {
                return NotFound();
            }
            ViewData["GästId"] = new SelectList(_context.Gäster, "Id", "Id", bokning.GästId);
            ViewData["RumId"] = new SelectList(_context.Rum, "Id", "Id", bokning.RumId);
            return View(bokning);
        }

        // POST: Boknings/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Incheckning,Utcheckning,GästId,RumId")] Bokning bokning)
        {
            if (id != bokning.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(bokning);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BokningExists(bokning.Id))
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
            ViewData["GästId"] = new SelectList(_context.Gäster, "Id", "Id", bokning.GästId);
            ViewData["RumId"] = new SelectList(_context.Rum, "Id", "Id", bokning.RumId);
            return View(bokning);
        }

        // GET: Boknings/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var bokning = await _context.Bokningar
                .Include(b => b.Gäst)
                .Include(b => b.Rum)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (bokning == null)
            {
                return NotFound();
            }

            return View(bokning);
        }

        // POST: Boknings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var bokning = await _context.Bokningar.FindAsync(id);
            _context.Bokningar.Remove(bokning);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public IActionResult CheckFreeRooms()
        {
            return View();
        }

        public async Task<IActionResult> LookForAvailableRooms(DateTime BookFrom, DateTime BookTo, int NoOfMembers, Rum Rum)
        {

            var usergäst = new Gäst();

            var Antalupptagnaplatserinnomspannet = _context.Bokningar.Where(x => x.Incheckning >= BookFrom && x.Utcheckning <= BookTo)
                                            .Select(x => x.Rum.Antalsovplatser).Sum();

            var totalaplatser = _context.Rum.Select(x => x.Antalsovplatser).Sum();
            var user = await _userManager.GetUserAsync(User);

            if (totalaplatser - Antalupptagnaplatserinnomspannet >= NoOfMembers)
            {
                var resultgäst = _context.Gäster.Where(x => x.Förnamn == user.Namn).Select(x => x).ToList();
                if (!resultgäst.Any()) // if sats för att undivka dubbletter i db
                {
                    var nygäst = new Gäst { Förnamn = user.Namn, Efternamn = user.Efternamn };

                    await _context.Gäster.AddAsync(nygäst);
                    await _context.SaveChangesAsync();

                    var gäst = _context.Gäster.Where(x => x.Förnamn == user.Namn).Select(x => x).ToList();
                    usergäst = gäst[0];
                }
                else
                {
                    usergäst = resultgäst[0];
                }


                var ledigtrum = _context.Rum.Select(x => x.Id).ToList();
                var testrum = ledigtrum[0];

                //problem 1. Väljer alltid rum1(Jan)
                var nybokning = new Bokning { Gäst = usergäst, Incheckning = BookFrom, Utcheckning = BookTo, RumId = testrum };
               
                await _context.Bokningar.AddAsync(nybokning);
                await _context.SaveChangesAsync();

                return View();
            }
            else
            {
                ViewBag.Errormessage = "Det verkar som alla rummen är upptagna. Försök med ett annat datum!";
                return View();
            }
        }
        


        private bool BokningExists(int id)
        {
            return _context.Bokningar.Any(e => e.Id == id);
        }
    }
}
