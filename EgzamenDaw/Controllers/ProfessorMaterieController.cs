using EgzamenDaw.Data;
using EgzamenDaw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EgzamenDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorMaterieController : ControllerBase
    {
        private readonly Lab4Context _context;

        public ProfesorMaterieController(Lab4Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<ProfesorMaterie>> Get()
        {
            return await _context.ProfesorMaterie.ToListAsync();
        }

        [HttpGet("{profesorId}/{materieId}")]
        public async Task<ProfesorMaterie> GetById(int profesorId, int materieId)
        {
            return await _context.ProfesorMaterie.FirstOrDefaultAsync(sc => sc.ProfesorId == profesorId && sc.MaterieId == materieId);
        }

        [HttpDelete("{profesorId}/{materieId}")]
        public async Task<List<ProfesorMaterie>> Delete(int profesorId, int materieId)
        {
            var profesorMaterie = await _context.ProfesorMaterie.FindAsync(profesorId, materieId);
            if (profesorMaterie != null)
            {
                _context.ProfesorMaterie.Remove(profesorMaterie);
                await _context.SaveChangesAsync();
            }
            return await _context.ProfesorMaterie.ToListAsync();
        }
    }
}
