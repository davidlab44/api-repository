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
    public class Glapp_SP_DrugsDeliveryRestocksHeaderResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public Glapp_SP_DrugsDeliveryRestocksHeaderResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/Glapp_SP_DrugsDeliveryRestocksHeaderResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryRestocksHeaderResult>>> GetGlapp_SP_DrugsDeliveryRestocksHeaderResult()
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksHeaderResult == null)
          {
              return NotFound();
          }
            return await _context.Glapp_SP_DrugsDeliveryRestocksHeaderResult.ToListAsync();
        }

        // GET: api/Glapp_SP_DrugsDeliveryRestocksHeaderResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestocksHeaderResult>> GetGlapp_SP_DrugsDeliveryRestocksHeaderResult(string id)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksHeaderResult == null)
          {
              return NotFound();
          }
            var glapp_SP_DrugsDeliveryRestocksHeaderResult = await _context.Glapp_SP_DrugsDeliveryRestocksHeaderResult.FindAsync(id);

            if (glapp_SP_DrugsDeliveryRestocksHeaderResult == null)
            {
                return NotFound();
            }

            return glapp_SP_DrugsDeliveryRestocksHeaderResult;
        }

        // PUT: api/Glapp_SP_DrugsDeliveryRestocksHeaderResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlapp_SP_DrugsDeliveryRestocksHeaderResult(string id, Glapp_SP_DrugsDeliveryRestocksHeaderResult glapp_SP_DrugsDeliveryRestocksHeaderResult)
        {
            if (id != glapp_SP_DrugsDeliveryRestocksHeaderResult.License)
            {
                return BadRequest();
            }

            _context.Entry(glapp_SP_DrugsDeliveryRestocksHeaderResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Glapp_SP_DrugsDeliveryRestocksHeaderResultExists(id))
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

        // POST: api/Glapp_SP_DrugsDeliveryRestocksHeaderResult
        [HttpPost]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestocksHeaderResult>> PostGlapp_SP_DrugsDeliveryRestocksHeaderResult(Glapp_SP_DrugsDeliveryRestocksHeaderResult glapp_SP_DrugsDeliveryRestocksHeaderResult)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksHeaderResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.Glapp_SP_DrugsDeliveryRestocksHeaderResult'  is null.");
          }
            _context.Glapp_SP_DrugsDeliveryRestocksHeaderResult.Add(glapp_SP_DrugsDeliveryRestocksHeaderResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Glapp_SP_DrugsDeliveryRestocksHeaderResultExists(glapp_SP_DrugsDeliveryRestocksHeaderResult.License))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGlapp_SP_DrugsDeliveryRestocksHeaderResult", new { id = glapp_SP_DrugsDeliveryRestocksHeaderResult.License }, glapp_SP_DrugsDeliveryRestocksHeaderResult);
        }

        // DELETE: api/Glapp_SP_DrugsDeliveryRestocksHeaderResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlapp_SP_DrugsDeliveryRestocksHeaderResult(string id)
        {
            if (_context.Glapp_SP_DrugsDeliveryRestocksHeaderResult == null)
            {
                return NotFound();
            }
            var glapp_SP_DrugsDeliveryRestocksHeaderResult = await _context.Glapp_SP_DrugsDeliveryRestocksHeaderResult.FindAsync(id);
            if (glapp_SP_DrugsDeliveryRestocksHeaderResult == null)
            {
                return NotFound();
            }

            _context.Glapp_SP_DrugsDeliveryRestocksHeaderResult.Remove(glapp_SP_DrugsDeliveryRestocksHeaderResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Glapp_SP_DrugsDeliveryRestocksHeaderResultExists(string id)
        {
            return (_context.Glapp_SP_DrugsDeliveryRestocksHeaderResult?.Any(e => e.License == id)).GetValueOrDefault();
        }
    }
}
