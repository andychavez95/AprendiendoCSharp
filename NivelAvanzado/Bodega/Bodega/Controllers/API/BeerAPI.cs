using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bodega.Models;
using Microsoft.EntityFrameworkCore;
using Bodega.Models.ViewModels;

namespace Bodega.Controllers.API
{
    [Route("api/[controller]")] 
    [ApiController]
    public class BeerAPI : ControllerBase
    {
        private readonly BodegaContext _context;

        public BeerAPI(BodegaContext context)
        {
            _context = context;
        }

        public async Task<List<BeerBrandViewModel>> Get()
            => await _context.Beers.Include(b => b.Brand)
                .Select(b => new BeerBrandViewModel
                {
                    BeerName = b.BeerName,
                    BrandName = b.Brand.BrandName
                }).ToListAsync();
    }
}
