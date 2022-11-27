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
    public class ClientsController : Controller
    {
        private readonly LendsContext _context;

        public ClientsController(LendsContext context)
        {
            _context = context;
        }

        // GET: Clients
        public async Task<IActionResult> Index()
        {
            var lendsContext = _context.Client.Include(c => c.Address);
            return View(await lendsContext.ToListAsync());
        }

        // GET: Clients/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .Include(c => c.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            client.Rents = _context.Rent.Where(rent => rent.ClientId == id).Include(rent => rent.Game).OrderBy(rent => rent.IsActive ? 0 : 1).ToList();
            return View(client);
        }

        // GET: Clients/Create
        public IActionResult Create()
        {
            //Criar uma instancia do nosso ViewModel
            var viewModel = new ClientFormViewModel();

            //Encaminhar a ViewModel com as informações para compilar a view(html)
            return View(viewModel);
        }

        // POST: Clients/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(ClientFormViewModel clientForm)
        {
            var address = await _context.Address
                            .FirstOrDefaultAsync(m => m.ZipCode == clientForm.Address.ZipCode && m.Number == clientForm.Address.Number && m.AdditionalInformation == clientForm.Address.AdditionalInformation);
            if (address == null)
            {
                address = new Address
                {
                    ZipCode = clientForm.Address.ZipCode,
                    Number = clientForm.Address.Number,
                    AdditionalInformation = clientForm.Address.AdditionalInformation
                };

                if (ModelState.IsValid)
                {
                    _context.Add(address);
                    await _context.SaveChangesAsync();
                }
            }
            if (ModelState.IsValid)
            {
                clientForm.Client.AddressId = address.Id;
                _context.Add(clientForm.Client);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", address.Id);
            return View(clientForm);
        }

        // GET: Clients/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {

            if (id == null)
            {
                return NotFound();
            }

            Client client = _context.Client.Include(obj => obj.Address).FirstOrDefault(obj => obj.Id == id);

            if (client == null)
            {
                return NotFound();
            }

            var viewModel = new ClientFormViewModel();

            viewModel.Addresses = _context.Address.ToList();
            viewModel.Client = client;

            return View(viewModel);
        }

        // POST: Clients/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(ClientFormViewModel clientForm)
        {
            //if (id != clientForm.Client.Id)
            //{
            //    return NotFound();
            //}

            var address = await _context.Address
                            .FirstOrDefaultAsync(m => m.ZipCode == clientForm.Client.Address.ZipCode && m.Number == clientForm.Client.Address.Number && m.AdditionalInformation == clientForm.Client.Address.AdditionalInformation);
            if (address == null)
            {
                address = new Address
                {
                    ZipCode = clientForm.Client.Address.ZipCode,
                    Number = clientForm.Client.Address.Number,
                    AdditionalInformation = clientForm.Client.Address.AdditionalInformation
                };

                if (ModelState.IsValid)
                {
                    _context.Add(address);
                    await _context.SaveChangesAsync();
                }
            }
            if (ModelState.IsValid)
            {
                try
                {
                    clientForm.Client.AddressId = address.Id;
                    clientForm.Client.Address = address;
                    _context.Update(clientForm.Client);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientExists(clientForm.Client.Id))
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
            ViewData["AddressId"] = new SelectList(_context.Address, "Id", "Id", address.Id);
            return View(clientForm);
        }

        // GET: Clients/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var client = await _context.Client
                .Include(c => c.Address)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (client == null)
            {
                return NotFound();
            }

            return View(client);
        }

        // POST: Clients/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var client = await _context.Client.FindAsync(id);
            _context.Client.Remove(client);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientExists(int id)
        {
            return _context.Client.Any(e => e.Id == id);
        }
    }
}
