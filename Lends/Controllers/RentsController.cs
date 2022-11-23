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
using Lends.Models.Enums;

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
        public async Task<IActionResult> Index(string rentSearch)
        {
            ViewData["CurrentFilter"] = rentSearch;
            var rents = from s in _context.Rent.Include(r => r.Client).Include(r => r.Game)
                        select s;
            if (string.IsNullOrEmpty(rentSearch))
            {
                rents = rents.Where(rent => rent.IsActive == true);
            }
            else
            {
                rents = rents.Where(rent => rent.IsActive == false);
            }

            return View(await rents.AsNoTracking().ToListAsync());
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
            }
            ViewData["ClientId"] = new SelectList(_context.Client, "Id", "Id", rent.ClientId);
            ViewData["GameId"] = new SelectList(_context.Game, "Id", "Id", rent.GameId);

            var game = await _context.Game
                .Include(g => g.Producer)
                .FirstOrDefaultAsync(m => m.Id == rent.GameId);
            if (game == null || game.Status != GameStatus.AVAILABLE)
            {
                return NotFound();
            }
            try
            {
                game.Status = GameStatus.RENTED;
                _context.Update(game);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Rents/ReturnBook/5
        public async Task<IActionResult> ReturnBook(int? id)
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

        // POST: Rents/ReturnBook/5
        [HttpPost, ActionName("ReturnBook")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> ReturnBookConfirmed(int id)
        {
            var rent = await _context.Rent.FindAsync(id);
            try
            {
                rent.IsActive = false;
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
            var game = await _context.Game
                .Include(g => g.Producer)
                .FirstOrDefaultAsync(m => m.Id == rent.GameId);
            if (game == null || game.Status != GameStatus.RENTED)
            {
                return NotFound();
            }
            try
            {
                game.Status = GameStatus.AVAILABLE;
                _context.Update(game);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }
            return RedirectToAction(nameof(Index));
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
