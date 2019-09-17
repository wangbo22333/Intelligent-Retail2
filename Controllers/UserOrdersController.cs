using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Intelligent_Retail2.Models;

namespace Intelligent_Retail2.Controllers
{
    public class UserOrdersController : Controller
    {
        private readonly Intelligent_Retail2Context _context;

        public UserOrdersController(Intelligent_Retail2Context context)
        {
            _context = context;
        }

        // GET: UserOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.UserOrder.ToListAsync());
        }

        // GET: UserOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userOrder = await _context.UserOrder
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userOrder == null)
            {
                return NotFound();
            }

            return View(userOrder);
        }

        // GET: UserOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UserOrders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,UserOrderID,UserPhone,ProductID,ProductNumber")] UserOrder userOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(userOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(userOrder);
        }

        // GET: UserOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userOrder = await _context.UserOrder.FindAsync(id);
            if (userOrder == null)
            {
                return NotFound();
            }
            return View(userOrder);
        }

        // POST: UserOrders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,UserOrderID,UserPhone,ProductID,ProductNumber")] UserOrder userOrder)
        {
            if (id != userOrder.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(userOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UserOrderExists(userOrder.ID))
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
            return View(userOrder);
        }

        // GET: UserOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var userOrder = await _context.UserOrder
                .FirstOrDefaultAsync(m => m.ID == id);
            if (userOrder == null)
            {
                return NotFound();
            }

            return View(userOrder);
        }

        // POST: UserOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var userOrder = await _context.UserOrder.FindAsync(id);
            _context.UserOrder.Remove(userOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UserOrderExists(int id)
        {
            return _context.UserOrder.Any(e => e.ID == id);
        }
    }
}
