using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.DATA;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TClassesController : ControllerBase
    {
        private readonly TClasseContext _context;

        public TClassesController(TClasseContext context)
        {
            _context = context;
        }

        // GET: api/TClasses
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TClasse>>> GetTClasses()
        {
            return await _context.TClasses.ToListAsync();
        }

        // GET: api/TClasses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TClasse>> GetTClasse(int id)
        {
            var tClasse = await _context.TClasses.FindAsync(id);

            if (tClasse == null)
            {
                return NotFound();
            }

            return tClasse;
        }

        // PUT: api/TClasses/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTClasse(int id, TClasse tClasse)
        {
            if (id != tClasse.Id)
            {
                return BadRequest();
            }

            _context.Entry(tClasse).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TClasseExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TClasses
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TClasse>> PostTClasse(TClasse tClasse)
        {
            _context.TClasses.Add(tClasse);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTClasse", new { id = tClasse.Id }, tClasse);
        }

        // DELETE: api/TClasses/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTClasse(int id)
        {
            var tClasse = await _context.TClasses.FindAsync(id);
            if (tClasse == null)
            {
                return NotFound();
            }

            _context.TClasses.Remove(tClasse);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TClasseExists(int id)
        {
            return _context.TClasses.Any(e => e.Id == id);
        }
    }
}
