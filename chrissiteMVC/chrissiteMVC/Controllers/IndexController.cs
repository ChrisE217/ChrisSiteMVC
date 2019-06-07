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
using System.Diagnostics;

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

        // GET: Index/Details
        public async Task<IActionResult> Details()
        {

            var indexDataModel = await _context.IndexDataModel
                .FirstOrDefaultAsync(m => m.Id == "1");
            if (indexDataModel == null)
            {
                return NotFound();
            }

            return View(indexDataModel);
        }

        // GET: Index/Edit
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit()
        {
            var indexDataModel = await _context.IndexDataModel.FindAsync("1");
            if (indexDataModel == null)
            {
                return NotFound();
            }
            return View(indexDataModel);
        }

        // POST: Index/Edit
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit([Bind("Id,Name,Occupation,Description,Picture,Email,PhoneNo,Cv")] IndexDataModel indexDataModel)
        {
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

        private bool IndexDataModelExists(string id)
        {
            return _context.IndexDataModel.Any(e => e.Id == id);
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
