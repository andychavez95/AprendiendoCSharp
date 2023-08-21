using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Bodega.Models;
using Microsoft.EntityFrameworkCore;
using Bodega.Models.ViewModels;

namespace Bodega.Controllers
{
    public class BeerController : Controller
    {
        private readonly BodegaContext _context;

        public BeerController(BodegaContext context) 
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var beers = _context.Beers.Include(b => b.Brand);
            return View(await beers.ToListAsync());
        } 

        // [HttpPost]
        // [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(BeerViewModel model)
        {
            if (ModelState.IsValid)
            {
                Beer beer = new Beer()
                {
                    BrandId = model.BrandId,
                    BeerName = model.BeerName
                };

                _context.Add(beer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));                
            }

            ViewData["Brands"] = new SelectList(_context.Brands, "BrandId", "BrandName", model.BrandId);
            return View(model);
        }
    }
}
