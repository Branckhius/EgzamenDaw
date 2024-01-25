using EgzamenDaw.Data;
using EgzamenDaw.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace EgzamenDaw.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProfesorController : ControllerBase
    {
        private readonly Lab4Context _context;

        public ProfesorController(Lab4Context context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<List<Profesor>> Get()
        {
            return await _context.Professor.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<Profesor> GetById(int id)
        {
            return await _context.Professor.FirstOrDefaultAsync(s => s.Id == id);
        }

        [HttpPost]
        public async Task<List<Profesor>> Add(Profesor professor)
        {
            _context.Professor.Add(professor);
            await _context.SaveChangesAsync();
            return await _context.Professor.ToListAsync();
        }

        [HttpDelete("{id}")]
        public async Task<List<Profesor>> Delete(int id)
        {
            var profesor = await _context.Professor.FindAsync(id);
            if (profesor != null)
            {
                _context.Professor.Remove(profesor);
                await _context.SaveChangesAsync();
            }
            return await _context.Professor.ToListAsync();
        }
    }
}
