using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using generalapi2.Models;
using System.Text.Json.Nodes;

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


        // POST: api/Glapp_SP_DrugsDeliveryConfirmationResult
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryConfirmationResult>>> PostGlapp_SP_DrugsDeliveryConfirmationResult(long? P_RestockID, string P_User, string P_Vehicle, string P_DeliveryConfirmationImageUrl, string P_DeliveryConfirmationComments)
        {
            if (_context.Glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }

            /*
            return _context.Glapp_SP_DrugsDeliveryConfirmationResult
              .FromSqlRaw($" EXEC Glapp_SP_DrugsDeliveryConfirmation 'ADMIN', 'HFQ753','" + glappDrugsDeliveryConsumptionDet.ToJsonString().Replace("{", "{{").Replace("}", "}}") + "' ").ToList();
            */
            return _context.Glapp_SP_DrugsDeliveryConfirmationResult
              .FromSqlRaw($" EXEC Glapp_SP_DrugsDeliveryConfirmation {P_RestockID},'{P_User}', '{P_Vehicle}', '{P_DeliveryConfirmationImageUrl}','{P_DeliveryConfirmationComments}'").ToList();

        }

        /*
        // GET: api/Glapp_SP_DrugsDeliveryConfirmationResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryConfirmationResult>>> GetGlapp_SP_DrugsDeliveryConfirmationResult()
        {
          if (_context.Glapp_SP_DrugsDeliveryConfirmationResult == null)
          {
              return NotFound();
          }
            return await _context.Glapp_SP_DrugsDeliveryConfirmationResult.ToListAsync();
        }

        // GET: api/Glapp_SP_DrugsDeliveryConfirmationResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryConfirmationResult>> GetGlapp_SP_DrugsDeliveryConfirmationResult(string id)
        {
          if (_context.Glapp_SP_DrugsDeliveryConfirmationResult == null)
          {
              return NotFound();
          }
            var glapp_SP_DrugsDeliveryConfirmationResult = await _context.Glapp_SP_DrugsDeliveryConfirmationResult.FindAsync(id);

            if (glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }

            return glapp_SP_DrugsDeliveryConfirmationResult;
        }

        // PUT: api/Glapp_SP_DrugsDeliveryConfirmationResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlapp_SP_DrugsDeliveryConfirmationResult(string id, Glapp_SP_DrugsDeliveryConfirmationResult glapp_SP_DrugsDeliveryConfirmationResult)
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

        // POST: api/Glapp_SP_DrugsDeliveryConfirmationResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryConfirmationResult>> PostGlapp_SP_DrugsDeliveryConfirmationResult(Glapp_SP_DrugsDeliveryConfirmationResult glapp_SP_DrugsDeliveryConfirmationResult)
        {
          if (_context.Glapp_SP_DrugsDeliveryConfirmationResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.Glapp_SP_DrugsDeliveryConfirmationResult'  is null.");
          }
            _context.Glapp_SP_DrugsDeliveryConfirmationResult.Add(glapp_SP_DrugsDeliveryConfirmationResult);
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

        // DELETE: api/Glapp_SP_DrugsDeliveryConfirmationResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlapp_SP_DrugsDeliveryConfirmationResult(string id)
        {
            if (_context.Glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }
            var glapp_SP_DrugsDeliveryConfirmationResult = await _context.Glapp_SP_DrugsDeliveryConfirmationResult.FindAsync(id);
            if (glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }

            _context.Glapp_SP_DrugsDeliveryConfirmationResult.Remove(glapp_SP_DrugsDeliveryConfirmationResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Glapp_SP_DrugsDeliveryConfirmationResultExists(string id)
        {
            return (_context.Glapp_SP_DrugsDeliveryConfirmationResult?.Any(e => e.MENSAJE == id)).GetValueOrDefault();
        }
        */
    }
}
