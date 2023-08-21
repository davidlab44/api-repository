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
    public class Glapp_SP_DrugsDeliveryConfirmationResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public Glapp_SP_DrugsDeliveryConfirmationResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }



        /*
        // GET: api/APP_SP_DrugsDeliveryConsumerViewSaveResult2
        [HttpGet]
        public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewSaveResult2>>> GetGlapp_SP_DrugsDeliveryConfirmationResult()
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult2 == null)
          {
              return NotFound();
          }
            return await _context.APP_SP_DrugsDeliveryConsumerViewSaveResult2.ToListAsync();
        }

        // GET: api/APP_SP_DrugsDeliveryConsumerViewSaveResult2/5
        [HttpGet("{id}")]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult2>> GetGlapp_SP_DrugsDeliveryConfirmationResult(string id)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult2 == null)
          {
              return NotFound();
          }
            var glapp_SP_DrugsDeliveryConfirmationResult = await _context.APP_SP_DrugsDeliveryConsumerViewSaveResult2.FindAsync(id);

            if (glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }

            return glapp_SP_DrugsDeliveryConfirmationResult;
        }

        // PUT: api/APP_SP_DrugsDeliveryConsumerViewSaveResult2/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlapp_SP_DrugsDeliveryConfirmationResult(string id, APP_SP_DrugsDeliveryConsumerViewSaveResult2 glapp_SP_DrugsDeliveryConfirmationResult)
        {
            if (id != glapp_SP_DrugsDeliveryConfirmationResult.MENSAJE)
            {
                return BadRequest();
            }

            _context.Entry(glapp_SP_DrugsDeliveryConfirmationResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Glapp_SP_DrugsDeliveryConfirmationResultExists(id))
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

        // POST: api/APP_SP_DrugsDeliveryConsumerViewSaveResult2
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult2>> PostGlapp_SP_DrugsDeliveryConfirmationResult(APP_SP_DrugsDeliveryConsumerViewSaveResult2 glapp_SP_DrugsDeliveryConfirmationResult)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult2 == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.APP_SP_DrugsDeliveryConsumerViewSaveResult2'  is null.");
          }
            _context.APP_SP_DrugsDeliveryConsumerViewSaveResult2.Add(glapp_SP_DrugsDeliveryConfirmationResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Glapp_SP_DrugsDeliveryConfirmationResultExists(glapp_SP_DrugsDeliveryConfirmationResult.MENSAJE))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGlapp_SP_DrugsDeliveryConfirmationResult", new { id = glapp_SP_DrugsDeliveryConfirmationResult.MENSAJE }, glapp_SP_DrugsDeliveryConfirmationResult);
        }

        // DELETE: api/APP_SP_DrugsDeliveryConsumerViewSaveResult2/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlapp_SP_DrugsDeliveryConfirmationResult(string id)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult2 == null)
            {
                return NotFound();
            }
            var glapp_SP_DrugsDeliveryConfirmationResult = await _context.APP_SP_DrugsDeliveryConsumerViewSaveResult2.FindAsync(id);
            if (glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }

            _context.APP_SP_DrugsDeliveryConsumerViewSaveResult2.Remove(glapp_SP_DrugsDeliveryConfirmationResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Glapp_SP_DrugsDeliveryConfirmationResultExists(string id)
        {
            return (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult2?.Any(e => e.MENSAJE == id)).GetValueOrDefault();
        }
        */
    }
}
