using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using COMP003B.Final.Data;
using COMP003B.Final.Models;

namespace COMP003B.Final.Controllers
{
    public class OrderproductsController : Controller
    {
        private readonly OnlineStoreHubContext _context;

        public OrderproductsController(OnlineStoreHubContext context)
        {
            _context = context;
        }

        // GET: Orderproducts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Orderproducts.ToListAsync());
        }

        // GET: Orderproducts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderproduct = await _context.Orderproducts
                .FirstOrDefaultAsync(m => m.orderProductId == id);
            if (orderproduct == null)
            {
                return NotFound();
            }

            return View(orderproduct);
        }

        // GET: Orderproducts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Orderproducts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("orderProductId,productId,orderId,orderProductStatus")] Orderproduct orderproduct)
        {
            if (ModelState.IsValid)
            {
                _context.Add(orderproduct);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(orderproduct);
        }

        // GET: Orderproducts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderproduct = await _context.Orderproducts.FindAsync(id);
            if (orderproduct == null)
            {
                return NotFound();
            }
            return View(orderproduct);
        }

        // POST: Orderproducts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("orderProductId,productId,orderId,orderProductStatus")] Orderproduct orderproduct)
        {
            if (id != orderproduct.orderProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(orderproduct);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrderproductExists(orderproduct.orderProductId))
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
            return View(orderproduct);
        }

        // GET: Orderproducts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var orderproduct = await _context.Orderproducts
                .FirstOrDefaultAsync(m => m.orderProductId == id);
            if (orderproduct == null)
            {
                return NotFound();
            }

            return View(orderproduct);
        }

        // POST: Orderproducts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var orderproduct = await _context.Orderproducts.FindAsync(id);
            if (orderproduct != null)
            {
                _context.Orderproducts.Remove(orderproduct);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrderproductExists(int id)
        {
            return _context.Orderproducts.Any(e => e.orderProductId == id);
        }
    }
}
