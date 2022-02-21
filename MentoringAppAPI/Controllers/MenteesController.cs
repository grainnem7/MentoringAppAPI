#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MentoringAppAPI.Data;
using MentoringAppAPI.Entities;

namespace MentoringAppAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenteesController : ControllerBase
    {
        private readonly MentoringAppAPIContext _context;

        public MenteesController(MentoringAppAPIContext context)
        {
            _context = context;
            _context.Database.EnsureCreated();
        }

        // GET: api/Mentees
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Mentee>>> GetMentee()
        {
            
            return await _context.Mentee.ToListAsync();
        }

        // GET: api/Mentees/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Mentee>> GetMentee(Guid id)
        {
            var mentee = await _context.Mentee.FindAsync(id);

            if (mentee == null)
            {
                return NotFound();
            }

            return mentee;
        }

        // PUT: api/Mentees/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMentee(Guid id, Mentee mentee)
        {
            if (id != mentee.MenteeId)
            {
                return BadRequest();
            }

            _context.Entry(mentee).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MenteeExists(id))
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

        // POST: api/Mentees
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Mentee>> PostMentee(Mentee mentee)
        {
          
            _context.Mentee.Add(mentee);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMentee", new { id = mentee.MenteeId }, mentee);
        }

        // DELETE: api/Mentees/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMentee(Guid id)
        {
            var mentee = await _context.Mentee.FindAsync(id);
            if (mentee == null)
            {
                return NotFound();
            }

            _context.Mentee.Remove(mentee);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MenteeExists(Guid id)
        {
            return _context.Mentee.Any(e => e.MenteeId == id);
        }
    }
}
