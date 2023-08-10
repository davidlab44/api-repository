using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using generalapi2.Models;

namespace generalapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlappDrugsDeliveryConfirmationsController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public GlappDrugsDeliveryConfirmationsController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/GlappDrugsDeliveryConfirmations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlappDrugsDeliveryConfirmation>>> GetGlappDrugsDeliveryConfirmations()
        {
          if (_context.GlappDrugsDeliveryConfirmations == null)
          {
              return NotFound();
          }
            return await _context.GlappDrugsDeliveryConfirmations.ToListAsync();
        }

        // GET: api/GlappDrugsDeliveryConfirmations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlappDrugsDeliveryConfirmation>> GetGlappDrugsDeliveryConfirmation(long id)
        {
          if (_context.GlappDrugsDeliveryConfirmations == null)
          {
              return NotFound();
          }
            var glappDrugsDeliveryConfirmation = await _context.GlappDrugsDeliveryConfirmations.FindAsync(id);

            if (glappDrugsDeliveryConfirmation == null)
            {
                return NotFound();
            }

            return glappDrugsDeliveryConfirmation;
        }

        // PUT: api/GlappDrugsDeliveryConfirmations/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlappDrugsDeliveryConfirmation(long id, GlappDrugsDeliveryConfirmation glappDrugsDeliveryConfirmation)
        {
            if (id != glappDrugsDeliveryConfirmation.ConfirmationId)
            {
                return BadRequest();
            }

            _context.Entry(glappDrugsDeliveryConfirmation).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlappDrugsDeliveryConfirmationExists(id))
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

        // POST: api/GlappDrugsDeliveryConfirmations
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GlappDrugsDeliveryConfirmation>> PostGlappDrugsDeliveryConfirmation(GlappDrugsDeliveryConfirmation glappDrugsDeliveryConfirmation)
        {
          if (_context.GlappDrugsDeliveryConfirmations == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryConfirmations'  is null.");
          }
            _context.GlappDrugsDeliveryConfirmations.Add(glappDrugsDeliveryConfirmation);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlappDrugsDeliveryConfirmation", new { id = glappDrugsDeliveryConfirmation.ConfirmationId }, glappDrugsDeliveryConfirmation);
        }

        // DELETE: api/GlappDrugsDeliveryConfirmations/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlappDrugsDeliveryConfirmation(long id)
        {
            if (_context.GlappDrugsDeliveryConfirmations == null)
            {
                return NotFound();
            }
            var glappDrugsDeliveryConfirmation = await _context.GlappDrugsDeliveryConfirmations.FindAsync(id);
            if (glappDrugsDeliveryConfirmation == null)
            {
                return NotFound();
            }

            _context.GlappDrugsDeliveryConfirmations.Remove(glappDrugsDeliveryConfirmation);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlappDrugsDeliveryConfirmationExists(long id)
        {
            return (_context.GlappDrugsDeliveryConfirmations?.Any(e => e.ConfirmationId == id)).GetValueOrDefault();
        }
    }
}
