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
    public class TClasseLogsController : ControllerBase
    {
        private readonly TClasseContext _context;

        public TClasseLogsController(TClasseContext context)
        {
            _context = context;
        }

        // GET: api/TClasseLogs
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TClasseLog>>> GetTClasseLogs()
        {
            return await _context.TClasseLogs.ToListAsync();
        }

        // GET: api/TClasseLogs/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TClasseLog>> GetTClasseLog(int id)
        {
            var tClasseLog = await _context.TClasseLogs.FindAsync(id);

            if (tClasseLog == null)
            {
                return NotFound();
            }

            return tClasseLog;
        }

        // PUT: api/TClasseLogs/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTClasseLog(int id, TClasseLog tClasseLog)
        {
            if (id != tClasseLog.Id)
            {
                return BadRequest();
            }

            _context.Entry(tClasseLog).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TClasseLogExists(id))
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

        // POST: api/TClasseLogs
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TClasseLog>> PostTClasseLog(TClasseLog tClasseLog)
        {
            _context.TClasseLogs.Add(tClasseLog);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTClasseLog", new { id = tClasseLog.Id }, tClasseLog);
        }

        // DELETE: api/TClasseLogs/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTClasseLog(int id)
        {
            var tClasseLog = await _context.TClasseLogs.FindAsync(id);
            if (tClasseLog == null)
            {
                return NotFound();
            }

            _context.TClasseLogs.Remove(tClasseLog);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TClasseLogExists(int id)
        {
            return _context.TClasseLogs.Any(e => e.Id == id);
        }
    }
}
