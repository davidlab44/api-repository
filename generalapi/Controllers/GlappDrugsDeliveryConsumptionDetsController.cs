using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using generalapi.Models;

namespace generalapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlappDrugsDeliveryConsumptionDetsController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public GlappDrugsDeliveryConsumptionDetsController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/GlappDrugsDeliveryConsumptionDets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlappDrugsDeliveryConsumptionDet>>> GetGlappDrugsDeliveryConsumptionDets()
        {
          if (_context.GlappDrugsDeliveryConsumptionDets == null)
          {
              return NotFound();
          }
            return await _context.GlappDrugsDeliveryConsumptionDets.ToListAsync();
        }

        // GET: api/GlappDrugsDeliveryConsumptionDets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlappDrugsDeliveryConsumptionDet>> GetGlappDrugsDeliveryConsumptionDet(long id)
        {
          if (_context.GlappDrugsDeliveryConsumptionDets == null)
          {
              return NotFound();
          }
            var glappDrugsDeliveryConsumptionDet = await _context.GlappDrugsDeliveryConsumptionDets.FindAsync(id);

            if (glappDrugsDeliveryConsumptionDet == null)
            {
                return NotFound();
            }

            return glappDrugsDeliveryConsumptionDet;
        }

        // PUT: api/GlappDrugsDeliveryConsumptionDets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlappDrugsDeliveryConsumptionDet(long id, GlappDrugsDeliveryConsumptionDet glappDrugsDeliveryConsumptionDet)
        {
            if (id != glappDrugsDeliveryConsumptionDet.ConsumptionDetailId)
            {
                return BadRequest();
            }

            _context.Entry(glappDrugsDeliveryConsumptionDet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlappDrugsDeliveryConsumptionDetExists(id))
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

        // POST: api/GlappDrugsDeliveryConsumptionDets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<GlappDrugsDeliveryConsumptionDet>> PostGlappDrugsDeliveryConsumptionDet(GlappDrugsDeliveryConsumptionDet glappDrugsDeliveryConsumptionDet)
        public async Task<ActionResult<GlappDrugsDeliveryConsumptionDet>> PostGlappDrugsDeliveryConsumptionDet([FromBody] GlappDrugsDeliveryConsumptionDet[] jsonArray)
        {
          if (_context.GlappDrugsDeliveryConsumptionDets == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryConsumptionDets'  is null.");
          }

            foreach (var glappDrugsDeliveryConsumptionDet in jsonArray)
            {
                _context.GlappDrugsDeliveryConsumptionDets.Add(glappDrugsDeliveryConsumptionDet);
                await _context.SaveChangesAsync();
            }
            var er = jsonArray;
            return NoContent();
            //return CreatedAtAction("GetGlappDrugsDeliveryConsumptionDet", new { id = glappDrugsDeliveryConsumptionDet.ConsumptionDetailId }, glappDrugsDeliveryConsumptionDet);
        }

        // DELETE: api/GlappDrugsDeliveryConsumptionDets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlappDrugsDeliveryConsumptionDet(long id)
        {
            if (_context.GlappDrugsDeliveryConsumptionDets == null)
            {
                return NotFound();
            }
            var glappDrugsDeliveryConsumptionDet = await _context.GlappDrugsDeliveryConsumptionDets.FindAsync(id);
            if (glappDrugsDeliveryConsumptionDet == null)
            {
                return NotFound();
            }

            _context.GlappDrugsDeliveryConsumptionDets.Remove(glappDrugsDeliveryConsumptionDet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlappDrugsDeliveryConsumptionDetExists(long id)
        {
            return (_context.GlappDrugsDeliveryConsumptionDets?.Any(e => e.ConsumptionDetailId == id)).GetValueOrDefault();
        }
    }
}
