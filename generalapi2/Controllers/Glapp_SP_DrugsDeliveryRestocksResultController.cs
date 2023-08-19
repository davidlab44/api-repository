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
    public class Glapp_SP_DrugsDeliveryRestocksResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public Glapp_SP_DrugsDeliveryRestocksResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }


        /*
        // GET: api/Glapp_SP_DrugsDeliveryRestocksResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryRestocksResult>>> GetGlapp_SP_DrugsDeliveryRestocksResult()
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksResult == null)
          {
              return NotFound();
          }
            return await _context.Glapp_SP_DrugsDeliveryRestocksResult.ToListAsync();
        }

        // GET: api/Glapp_SP_DrugsDeliveryRestocksResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestocksResult>> GetGlapp_SP_DrugsDeliveryRestocksResult(long id)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksResult == null)
          {
              return NotFound();
          }
            var glapp_SP_DrugsDeliveryRestocksResult = await _context.Glapp_SP_DrugsDeliveryRestocksResult.FindAsync(id);

            if (glapp_SP_DrugsDeliveryRestocksResult == null)
            {
                return NotFound();
            }

            return glapp_SP_DrugsDeliveryRestocksResult;
        }

        // PUT: api/Glapp_SP_DrugsDeliveryRestocksResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlapp_SP_DrugsDeliveryRestocksResult(long id, Glapp_SP_DrugsDeliveryRestocksResult glapp_SP_DrugsDeliveryRestocksResult)
        {
            if (id != glapp_SP_DrugsDeliveryRestocksResult.RestockID)
            {
                return BadRequest();
            }

            _context.Entry(glapp_SP_DrugsDeliveryRestocksResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Glapp_SP_DrugsDeliveryRestocksResultExists(id))
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

        // POST: api/Glapp_SP_DrugsDeliveryRestocksResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestocksResult>> PostGlapp_SP_DrugsDeliveryRestocksResult(Glapp_SP_DrugsDeliveryRestocksResult glapp_SP_DrugsDeliveryRestocksResult)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.Glapp_SP_DrugsDeliveryRestocksResult'  is null.");
          }
            _context.Glapp_SP_DrugsDeliveryRestocksResult.Add(glapp_SP_DrugsDeliveryRestocksResult);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetGlapp_SP_DrugsDeliveryRestocksResult", new { id = glapp_SP_DrugsDeliveryRestocksResult.RestockID }, glapp_SP_DrugsDeliveryRestocksResult);
        }

        // DELETE: api/Glapp_SP_DrugsDeliveryRestocksResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlapp_SP_DrugsDeliveryRestocksResult(long id)
        {
            if (_context.Glapp_SP_DrugsDeliveryRestocksResult == null)
            {
                return NotFound();
            }
            var glapp_SP_DrugsDeliveryRestocksResult = await _context.Glapp_SP_DrugsDeliveryRestocksResult.FindAsync(id);
            if (glapp_SP_DrugsDeliveryRestocksResult == null)
            {
                return NotFound();
            }

            _context.Glapp_SP_DrugsDeliveryRestocksResult.Remove(glapp_SP_DrugsDeliveryRestocksResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        private bool Glapp_SP_DrugsDeliveryRestocksResultExists(long id)
        {
            return (_context.Glapp_SP_DrugsDeliveryRestocksResult?.Any(e => e.RestockID == id)).GetValueOrDefault();
        }
    }
}
