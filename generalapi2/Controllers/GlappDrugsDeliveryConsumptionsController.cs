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
    public class GlappDrugsDeliveryConsumptionsController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public GlappDrugsDeliveryConsumptionsController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/GlappDrugsDeliveryConsumptions
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlappDrugsDeliveryConsumption>>> GetGlappDrugsDeliveryConsumptions()
        {
          if (_context.GlappDrugsDeliveryConsumptions == null)
          {
              return NotFound();
          }
            return await _context.GlappDrugsDeliveryConsumptions.ToListAsync();
        }

        // GET: api/GlappDrugsDeliveryConsumptions/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlappDrugsDeliveryConsumption>> GetGlappDrugsDeliveryConsumption(long id)
        {
          if (_context.GlappDrugsDeliveryConsumptions == null)
          {
              return NotFound();
          }
            var glappDrugsDeliveryConsumption = await _context.GlappDrugsDeliveryConsumptions.FindAsync(id);

            if (glappDrugsDeliveryConsumption == null)
            {
                return NotFound();
            }

            return glappDrugsDeliveryConsumption;
        }

        // PUT: api/GlappDrugsDeliveryConsumptions/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlappDrugsDeliveryConsumption(long id, GlappDrugsDeliveryConsumption glappDrugsDeliveryConsumption)
        {
            if (id != glappDrugsDeliveryConsumption.ConsumptionId)
            {
                return BadRequest();
            }

            _context.Entry(glappDrugsDeliveryConsumption).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlappDrugsDeliveryConsumptionExists(id))
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

        // POST: api/GlappDrugsDeliveryConsumptions
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GlappDrugsDeliveryConsumption>> PostGlappDrugsDeliveryConsumption(GlappDrugsDeliveryConsumption glappDrugsDeliveryConsumption)
        {
            glappDrugsDeliveryConsumption.CreationDate = DateTime.Now;

          if (_context.GlappDrugsDeliveryConsumptions == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryConsumptions'  is null.");
          }
            _context.GlappDrugsDeliveryConsumptions.Add(glappDrugsDeliveryConsumption);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlappDrugsDeliveryConsumption", new { id = glappDrugsDeliveryConsumption.ConsumptionId }, glappDrugsDeliveryConsumption);
        }

        // DELETE: api/GlappDrugsDeliveryConsumptions/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlappDrugsDeliveryConsumption(long id)
        {
            if (_context.GlappDrugsDeliveryConsumptions == null)
            {
                return NotFound();
            }
            var glappDrugsDeliveryConsumption = await _context.GlappDrugsDeliveryConsumptions.FindAsync(id);
            if (glappDrugsDeliveryConsumption == null)
            {
                return NotFound();
            }

            _context.GlappDrugsDeliveryConsumptions.Remove(glappDrugsDeliveryConsumption);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlappDrugsDeliveryConsumptionExists(long id)
        {
            return (_context.GlappDrugsDeliveryConsumptions?.Any(e => e.ConsumptionId == id)).GetValueOrDefault();
        }
    }
}
