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
    public class GlappDrugsDeliveryRestocksController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public GlappDrugsDeliveryRestocksController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/GlappDrugsDeliveryRestocks
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GlappDrugsDeliveryRestock>>> GetGlappDrugsDeliveryRestocks()
        {
          if (_context.GlappDrugsDeliveryRestocks == null)
          {
              return NotFound();
          }
            return await _context.GlappDrugsDeliveryRestocks.ToListAsync();
        }

        // GET: api/GlappDrugsDeliveryRestocks/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GlappDrugsDeliveryRestock>> GetGlappDrugsDeliveryRestock(long id)
        {
          if (_context.GlappDrugsDeliveryRestocks == null)
          {
              return NotFound();
          }
            var glappDrugsDeliveryRestock = await _context.GlappDrugsDeliveryRestocks.FindAsync(id);

            if (glappDrugsDeliveryRestock == null)
            {
                return NotFound();
            }

            return glappDrugsDeliveryRestock;
        }

        // PUT: api/GlappDrugsDeliveryRestocks/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlappDrugsDeliveryRestock(long id, GlappDrugsDeliveryRestock glappDrugsDeliveryRestock)
        {
            if (id != glappDrugsDeliveryRestock.RestockId)
            {
                return BadRequest();
            }

            _context.Entry(glappDrugsDeliveryRestock).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GlappDrugsDeliveryRestockExists(id))
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

        // POST: api/GlappDrugsDeliveryRestocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GlappDrugsDeliveryRestock>> PostGlappDrugsDeliveryRestock(GlappDrugsDeliveryRestock glappDrugsDeliveryRestock)
        {
            glappDrugsDeliveryRestock.CreationDate = DateTime.Now;

            if (_context.GlappDrugsDeliveryRestocks == null)
            {
                return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryRestocks'  is null.");
            }
            _context.GlappDrugsDeliveryRestocks.Add(glappDrugsDeliveryRestock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlappDrugsDeliveryRestock", new { id = glappDrugsDeliveryRestock.RestockId }, glappDrugsDeliveryRestock);
        }

        /*
        // POST: api/GlappDrugsDeliveryRestocks
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GlappDrugsDeliveryRestock>> PostGlappDrugsDeliveryRestock(GlappDrugsDeliveryRestock glappDrugsDeliveryRestock)
        {
          if (_context.GlappDrugsDeliveryRestocks == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.GlappDrugsDeliveryRestocks'  is null.");
          }
            _context.GlappDrugsDeliveryRestocks.Add(glappDrugsDeliveryRestock);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlappDrugsDeliveryRestock", new { id = glappDrugsDeliveryRestock.RestockId }, glappDrugsDeliveryRestock);
        }
        */

        // DELETE: api/GlappDrugsDeliveryRestocks/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlappDrugsDeliveryRestock(long id)
        {
            if (_context.GlappDrugsDeliveryRestocks == null)
            {
                return NotFound();
            }
            var glappDrugsDeliveryRestock = await _context.GlappDrugsDeliveryRestocks.FindAsync(id);
            if (glappDrugsDeliveryRestock == null)
            {
                return NotFound();
            }

            _context.GlappDrugsDeliveryRestocks.Remove(glappDrugsDeliveryRestock);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool GlappDrugsDeliveryRestockExists(long id)
        {
            return (_context.GlappDrugsDeliveryRestocks?.Any(e => e.RestockId == id)).GetValueOrDefault();
        }
    }
}
