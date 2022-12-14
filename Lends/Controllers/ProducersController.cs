using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Lends.Data;
using Lends.Models;
using System.Net;

namespace Lends.Controllers
{
    public class ProducersController : Controller
    {
        private readonly LendsContext _context;

        public ProducersController(LendsContext context)
        {
            _context = context;
        }

        // GET: Producers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Producer.ToListAsync());
        }

        // GET: Producers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound("Fabricante não encontrado");
            }

            var producer = await _context.Producer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producer == null)
            {
                return NotFound("Fabricante não encontrado");
            }

            return View(producer);
        }

        // GET: Producers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Producers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Cnpj")] Producer producer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(producer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        // GET: Producers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound("Fabricante não encontrado");
            }

            var producer = await _context.Producer.FindAsync(id);
            if (producer == null)
            {
                return NotFound("Fabricante não encontrado");
            }
            return View(producer);
        }

        // POST: Producers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Cnpj")] Producer producer)
        {
            if (id != producer.Id)
            {
                return NotFound("Fabricante não encontrado");
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProducerExists(producer.Id))
                    {
                        return NotFound("Fabricante não encontrado");
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(producer);
        }

        // GET: Producers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound("Fabricante não encontrado");
            }

            var producer = await _context.Producer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (producer == null)
            {
                return NotFound("Fabricante não encontrado");
            }

            return View(producer);
        }

        // POST: Producers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producer = await _context.Producer.FindAsync(id);
            try
            {
                _context.Producer.Remove(producer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                ModelState.AddModelError("Error", "Operação não permitida");
                return View(producer);
            }
        }

        private bool ProducerExists(int id)
        {
            return _context.Producer.Any(e => e.Id == id);
        }
    }
}
