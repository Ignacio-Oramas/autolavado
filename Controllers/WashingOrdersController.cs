using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mvcrud.Data;
using mvcrud.Models;

namespace autolavado.Controllers
{
    public class WashingOrdersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public WashingOrdersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: WashingOrders
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.WashingOrders.Include(w => w.Employee).Include(w => w.Service).Include(w => w.Vehicle);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: WashingOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var washingOrder = await _context.WashingOrders
                .Include(w => w.Employee)
                .Include(w => w.Service)
                .Include(w => w.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (washingOrder == null)
            {
                return NotFound();
            }

            return View(washingOrder);
        }

        // GET: WashingOrders/Create
        public IActionResult Create()
        {
            ViewData["EmployeeId"] = new SelectList(_context.Empleados, "Id", "Id");
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id");
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id");
            return View();
        }

        // POST: WashingOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,VehicleId,ServiceId,EmployeeId,Fecha,Estado,Total")] WashingOrder washingOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(washingOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["EmployeeId"] = new SelectList(_context.Empleados, "Id", "Id", washingOrder.EmployeeId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", washingOrder.ServiceId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", washingOrder.VehicleId);
            return View(washingOrder);
        }

        // GET: WashingOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var washingOrder = await _context.WashingOrders.FindAsync(id);
            if (washingOrder == null)
            {
                return NotFound();
            }
            ViewData["EmployeeId"] = new SelectList(_context.Empleados, "Id", "Id", washingOrder.EmployeeId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", washingOrder.ServiceId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", washingOrder.VehicleId);
            return View(washingOrder);
        }

        // POST: WashingOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,VehicleId,ServiceId,EmployeeId,Fecha,Estado,Total")] WashingOrder washingOrder)
        {
            if (id != washingOrder.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(washingOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!WashingOrderExists(washingOrder.Id))
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
            ViewData["EmployeeId"] = new SelectList(_context.Empleados, "Id", "Id", washingOrder.EmployeeId);
            ViewData["ServiceId"] = new SelectList(_context.Services, "Id", "Id", washingOrder.ServiceId);
            ViewData["VehicleId"] = new SelectList(_context.Vehicles, "Id", "Id", washingOrder.VehicleId);
            return View(washingOrder);
        }

        // GET: WashingOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var washingOrder = await _context.WashingOrders
                .Include(w => w.Employee)
                .Include(w => w.Service)
                .Include(w => w.Vehicle)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (washingOrder == null)
            {
                return NotFound();
            }

            return View(washingOrder);
        }

        // POST: WashingOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var washingOrder = await _context.WashingOrders.FindAsync(id);
            if (washingOrder != null)
            {
                _context.WashingOrders.Remove(washingOrder);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool WashingOrderExists(int id)
        {
            return _context.WashingOrders.Any(e => e.Id == id);
        }
    }
}
