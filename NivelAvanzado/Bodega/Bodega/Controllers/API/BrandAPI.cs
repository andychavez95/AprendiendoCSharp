using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Bodega.Models;
using Microsoft.EntityFrameworkCore;

namespace Bodega.Controllers.API
{
    [Route("api/[controller]")] 
    [ApiController]
    public class BrandAPI : ControllerBase
    {
        private readonly BodegaContext _context;

        public BrandAPI(BodegaContext context)
        {
            _context = context;
        }

        public async Task<List<Brand>> Get()
            => await _context.Brands.ToListAsync();
    }
}
