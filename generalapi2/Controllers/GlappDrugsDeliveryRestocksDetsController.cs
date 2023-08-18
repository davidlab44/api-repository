using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TemplateBorrar1.Models;
using generalapi2.Models;

namespace generalapi2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GlappDrugsDeliveryRestocksDetsController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public GlappDrugsDeliveryRestocksDetsController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/GlappDrugsDeliveryRestocksDets
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlappDrugsDeliveryRestocksDet>>> GetGlappDrugsDeliveryRestocksDets()
        {
          if (_context.GlappDrugsDeliveryRestocksDets == null)
          {
              return NotFound();
          }
            return await _context.GlappDrugsDeliveryRestocksDets.ToListAsync();
        }

        // GET: api/GlappDrugsDeliveryRestocksDets/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlappDrugsDeliveryRestocksDet>> GetGlappDrugsDeliveryRestocksDet(long id)
        {
          if (_context.GlappDrugsDeliveryRestocksDets == null)
          {
              return NotFound();
          }
            var glappDrugsDeliveryRestocksDet = await _context.GlappDrugsDeliveryRestocksDets.FindAsync(id);

            if (glappDrugsDeliveryRestocksDet == null)
            {
                return NotFound();
            }

            return glappDrugsDeliveryRestocksDet;
        }

        // PUT: api/GlappDrugsDeliveryRestocksDets/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlappDrugsDeliveryRestocksDet(long id, GlappDrugsDeliveryRestocksDet glappDrugsDeliveryRestocksDet)
        {
            if (id != glappDrugsDeliveryRestocksDet.RestockDetailId)
            {
                return BadRequest();
            }

            _context.Entry(glappDrugsDeliveryRestocksDet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlappDrugsDeliveryRestocksDetExists(id))
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

        // POST: api/GlappDrugsDeliveryRestocksDets
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        //public async Task<ActionResult<GlappDrugsDeliveryConsumptionDet>> PostGlappDrugsDeliveryConsumptionDet(GlappDrugsDeliveryConsumptionDet glappDrugsDeliveryConsumptionDet)
        public async Task<ActionResult<GlappDrugsDeliveryRestocksDet>> PostGlappDrugsDeliveryRestocksDet([FromBody] GlappDrugsDeliveryRestocksDet[] jsonArray)
        {
            if (_context.GlappDrugsDeliveryRestocksDets == null)
            {
                return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryConsumptionDets'  is null.");
            }

            foreach (var glappDrugsDeliveryConsumptionDet in jsonArray)
            {
                _context.GlappDrugsDeliveryRestocksDets.Add(glappDrugsDeliveryConsumptionDet);
                await _context.SaveChangesAsync();
            }
            var er = jsonArray;
            return NoContent();
            //return CreatedAtAction("GetGlappDrugsDeliveryConsumptionDet", new { id = glappDrugsDeliveryConsumptionDet.ConsumptionDetailId }, glappDrugsDeliveryConsumptionDet);
        }

        /*
        [HttpPost]
        public async Task<ActionResult<GlappDrugsDeliveryRestocksDet>> PostGlappDrugsDeliveryRestocksDet(GlappDrugsDeliveryRestocksDet glappDrugsDeliveryRestocksDet)
        {
          if (_context.GlappDrugsDeliveryRestocksDets == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryRestocksDets'  is null.");
          }
            _context.GlappDrugsDeliveryRestocksDets.Add(glappDrugsDeliveryRestocksDet);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlappDrugsDeliveryRestocksDet", new { id = glappDrugsDeliveryRestocksDet.RestockDetailId }, glappDrugsDeliveryRestocksDet);
        }
        */

        // DELETE: api/GlappDrugsDeliveryRestocksDets/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlappDrugsDeliveryRestocksDet(long id)
        {
            if (_context.GlappDrugsDeliveryRestocksDets == null)
            {
                return NotFound();
            }
            var glappDrugsDeliveryRestocksDet = await _context.GlappDrugsDeliveryRestocksDets.FindAsync(id);
            if (glappDrugsDeliveryRestocksDet == null)
            {
                return NotFound();
            }

            _context.GlappDrugsDeliveryRestocksDets.Remove(glappDrugsDeliveryRestocksDet);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlappDrugsDeliveryRestocksDetExists(long id)
        {
            return (_context.GlappDrugsDeliveryRestocksDets?.Any(e => e.RestockDetailId == id)).GetValueOrDefault();
        }
    }
}
