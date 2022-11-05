using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lends.Data;
using Lends.Models;
using Lends.Models.ViewModel;

namespace Lends.Controllers
{
    public class RentsController : Controller
    {
        private readonly LendsContext _context;

        public RentsController(LendsContext context)
        {
            _context = context;
        }

        // GET: Rents
        public async Task<IActionResult> Index()
        {
            var lendsContext = _context.Rent.Include(r => r.Client).Include(r => r.Game);
            return View(await lendsContext.ToListAsync());
        }

        // GET: Rents/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rent
                .Include(r => r.Client)
                .Include(r => r.Game)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // GET: Rents/Create
        public IActionResult Create()
        {
            var viewModel = new RentFormViewModel();
            viewModel.Clients = _context.Client.ToList();
            viewModel.Games = _context.Game.ToList();
            return View(viewModel);
        }

        // POST: Rents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,GameId,ClientId,RentalDate,ReturnDate,Price")] Rent rent)
        {
            if (ModelState.IsValid)
            {
                _context.Add(rent);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", rent.ClientId);
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", rent.GameId);
            return View(rent);
        }

        // GET: Rents/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Rent rent = _context.Rent.Include(obj => obj.Client).FirstOrDefault(obj => obj.Id == id);
            rent = _context.Rent.Include(obj => obj.Game).FirstOrDefault(obj => obj.Id == id);

            if (rent == null)
            {
                return NotFound();
            }

            var viewModel = new RentFormViewModel();

            viewModel.Clients = _context.Client.ToList();
            viewModel.Games = _context.Game.ToList();
            viewModel.Rent = rent;

            return View(viewModel);
        }

        // POST: Rents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,GameId,ClientId,RentalDate,ReturnDate,Price")] Rent rent)
        {
            if (id != rent.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(rent);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RentExists(rent.Id))
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
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", rent.ClientId);
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", rent.GameId);
            return View(rent);
        }

        // GET: Rents/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var rent = await _context.Rent
                .Include(r => r.Client)
                .Include(r => r.Game)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (rent == null)
            {
                return NotFound();
            }

            return View(rent);
        }

        // POST: Rents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var rent = await _context.Rent.FindAsync(id);
            _context.Rent.Remove(rent);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RentExists(int id)
        {
            return _context.Rent.Any(e => e.Id == id);
        }
    }
}
