using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebApp3;
using WebApp3.Domains;
using WebApp3.Interfaces;
using WebApp3.Services;

namespace WebApp3.Controllers
{
    public class SpecialsController : Controller
    {
        private readonly ISpecialService _specialService;

        public SpecialsController(ISpecialService specialService)
        {
            _specialService = specialService;
        }

        // GET: Specials
        public async Task<IActionResult> Index()
        {
              return View(await _specialService.GetSpecials());
        }

        // GET: Specials/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var special = await _specialService.GetById((int)id);
            if (special == null)
            {
                return NotFound();
            }

            return View(special);
        }

        // GET: Specials/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specials/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Special special)
        {
            if (ModelState.IsValid)
            {
                await _specialService.Create(special);
                return RedirectToAction(nameof(Index));
            }
            return View(special);
        }

        // GET: Specials/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var special = await _specialService.GetById((int)id);
            if (special == null)
            {
                return NotFound();
            }
            return View(special);
        }

        // POST: Specials/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Special special)
        {
            if (id != special.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    await _specialService.Edit(special);
                }
                catch (DbUpdateConcurrencyException)
                { 
                    throw;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(special);
        }

        // GET: Specials/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null )
            {
                return NotFound();
            }

            var special = await _specialService.GetById((int)id);
            if (special == null)
            {
                return NotFound();
            }
            return View(special);
        }

        // POST: Specials/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var special = await _specialService.GetById((int)id);
            if (special != null)
            {
                await _specialService.Delete(special);
            }

            return RedirectToAction(nameof(Index));
        }
    }
}
