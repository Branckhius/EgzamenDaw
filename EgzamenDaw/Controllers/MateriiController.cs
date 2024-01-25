using EgzamenDaw.Data;
using EgzamenDaw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EgzamenDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MateriiController : Controller
    {
        private readonly Lab4Context _context;

        public MateriiController(Lab4Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Materii>> Get()
        {
            return await _context.Materii.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Materii> GetById(int id)
        {
            return await _context.Materii.FirstOrDefaultAsync(c => c.Id == id);
        }

        [HttpPost]
        public async Task<List<Materii>> Add(Materii materie)
        {
            _context.Materii.Add(materie);
            await _context.SaveChangesAsync();
            return await _context.Materii.ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<List<Materii>> Delete(int id)
        {
            var materie = await _context.Materii.FindAsync(id);
            if (materie != null)
            {
                _context.Materii.Remove(materie);
                await _context.SaveChangesAsync();
            }
            return await _context.Materii.ToListAsync();
        }
    }
}
