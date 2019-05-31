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
    public class ProjectController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProjectController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Project
        public async Task<IActionResult> Index()
        {
            return View(await _context.ProjectDataModel.ToListAsync());
        }

        // GET: Project/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDataModel = await _context.ProjectDataModel
                .FirstOrDefaultAsync(m => m.Title == id);
            if (projectDataModel == null)
            {
                return NotFound();
            }

            return View(projectDataModel);
        }

        // GET: Project/Create
        [Authorize(Roles = "Admin")]
        public IActionResult Create()
        {
            return View();
        }

        // POST: Project/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Create([Bind("Title,Link,Image,GithubLink,Description")] ProjectDataModel projectDataModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(projectDataModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(projectDataModel);
        }

        // GET: Project/Edit/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDataModel = await _context.ProjectDataModel.FindAsync(id);
            if (projectDataModel == null)
            {
                return NotFound();
            }
            return View(projectDataModel);
        }

        // POST: Project/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Edit(string id, [Bind("Title,Link,Image,GithubLink,Description")] ProjectDataModel projectDataModel)
        {
            if (id != projectDataModel.Title)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(projectDataModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProjectDataModelExists(projectDataModel.Title))
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
            return View(projectDataModel);
        }

        // GET: Project/Delete/5
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var projectDataModel = await _context.ProjectDataModel
                .FirstOrDefaultAsync(m => m.Title == id);
            if (projectDataModel == null)
            {
                return NotFound();
            }

            return View(projectDataModel);
        }

        // POST: Project/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var projectDataModel = await _context.ProjectDataModel.FindAsync(id);
            _context.ProjectDataModel.Remove(projectDataModel);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProjectDataModelExists(string id)
        {
            return _context.ProjectDataModel.Any(e => e.Title == id);
        }
    }
}
