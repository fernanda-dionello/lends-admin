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
    public class GamesController : Controller
    {
        private readonly LendsContext _context;

        public GamesController(LendsContext context)
        {
            _context = context;
        }

        // GET: Games
        public async Task<IActionResult> Index(GameStatus? statusSearch)
        {
            ViewData["CurrentFilter"] = statusSearch;
            var games = from s in _context.Game.Include(g => g.Producer)
                        select s;
            if (statusSearch != null)
            {
                games = games.Where(game => game.Status == statusSearch);
            }

            return View(await games.AsNoTracking().ToListAsync());
        }

        // GET: Games/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Producer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // GET: Games/Create
        public IActionResult Create()
        {
            //Criar uma instancia do nosso ViewModel
            var viewModel = new GameFormViewModel();

            //Acessar o banco de dados e retornar todos os registros de departamentos, adicionando eles nas lista de departamentos do ViewModel
            viewModel.Producers = _context.Producer.ToList();

            //Encaminhar a ViewModel com as informações para compilar a view(html)
            return View(viewModel);
        }

        // POST: Games/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Category,ProducerId,MinPlayers,MaxPlayers,Duration,Age,RentPrice,Image,Status")] Game game)
        {
            if (ModelState.IsValid)
            {
                _context.Add(game);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ProducerId"] = new SelectList(_context.Producer, "Id", "Id", game.ProducerId);
            return View(game);
        }

        // GET: Games/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Game game = _context.Game.Include(obj => obj.Producer).FirstOrDefault(obj => obj.Id == id);

            if (game == null)
            {
                return NotFound();
            }

            var viewModel = new GameFormViewModel();

            viewModel.Producers = _context.Producer.ToList();
            viewModel.Game = game;

            return View(viewModel);
        }

        // POST: Games/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Category,ProducerId,MinPlayers,MaxPlayers,Duration,Age,RentPrice,Image,Status")] Game game)
        {
            if (id != game.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(game);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!GameExists(game.Id))
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
            ViewData["ProducerId"] = new SelectList(_context.Producer, "Id", "Id", game.ProducerId);
            return View(game);
        }

        // GET: Games/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var game = await _context.Game
                .Include(g => g.Producer)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (game == null)
            {
                return NotFound();
            }

            return View(game);
        }

        // POST: Games/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var game = await _context.Game.FindAsync(id);
            _context.Game.Remove(game);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool GameExists(int id)
        {
            return _context.Game.Any(e => e.Id == id);
        }
    }
}
