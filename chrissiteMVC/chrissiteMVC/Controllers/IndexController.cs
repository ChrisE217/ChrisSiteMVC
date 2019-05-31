using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using chrissiteMVC.Data;
using chrissiteMVC.Models;
using Microsoft.AspNetCore.Authorization;

namespace chrissiteMVC.Controllers
{
    public class IndexController : Controller
    {
        private readonly ApplicationDbContext _context;

        public IndexController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Index
        public async Task<IActionResult> Index()
        {
            return View(await _context.IndexDataModel.FirstAsync());
        }

        // GET: Index/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexDataModel = await _context.IndexDataModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indexDataModel == null)
            {
                return NotFound();
            }

            return View(indexDataModel);
        }

        // GET: Index/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Index/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Id,Name,Occupation,Description,Picture,Email,PhoneNo,Cv")] IndexDataModel indexDataModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(indexDataModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(indexDataModel);
        }

        // GET: Index/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexDataModel = await _context.IndexDataModel.FindAsync(id);
            if (indexDataModel == null)
            {
                return NotFound();
            }
            return View(indexDataModel);
        }

        // POST: Index/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id, [Bind("Id,Name,Occupation,Description,Picture,Email,PhoneNo,Cv")] IndexDataModel indexDataModel)
        {
            if (id != indexDataModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(indexDataModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!IndexDataModelExists(indexDataModel.Id))
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
            return View(indexDataModel);
        }

        // GET: Index/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var indexDataModel = await _context.IndexDataModel
                .FirstOrDefaultAsync(m => m.Id == id);
            if (indexDataModel == null)
            {
                return NotFound();
            }

            return View(indexDataModel);
        }

        // POST: Index/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var indexDataModel = await _context.IndexDataModel.FindAsync(id);
            _context.IndexDataModel.Remove(indexDataModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool IndexDataModelExists(string id)
        {
            return _context.IndexDataModel.Any(e => e.Id == id);
        }
    }
}
