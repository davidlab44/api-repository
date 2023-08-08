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
    public class APP_SP_DrugsDeliveryConsumerViewHeaderResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public APP_SP_DrugsDeliveryConsumerViewHeaderResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        
        // GET: api/APP_SP_DrugsDeliveryConsumerViewHeaderResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewHeaderResult>>> GetAPP_SP_DrugsDeliveryConsumerViewHeaderResult()
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewHeaderResult == null)
          {
              return NotFound();
            }

            return _context.APP_SP_DrugsDeliveryConsumerViewHeaderResult
                  .FromSqlRaw($"exec APP_SP_DrugsDeliveryConsumerViewHeader 'admin'")
                  .ToList();
          


            //return await _context.APP_SP_DrugsDeliveryConsumerViewHeaderResult.ToListAsync();
        }
        

        
        // GET: api/APP_SP_DrugsDeliveryConsumerViewHeaderResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewHeaderResult>> GetAPP_SP_DrugsDeliveryConsumerViewHeaderResult(string id)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewHeaderResult == null)
          {
              return NotFound();
          }
            var aPP_SP_DrugsDeliveryConsumerViewHeaderResult = await _context.APP_SP_DrugsDeliveryConsumerViewHeaderResult.FindAsync(id);

            if (aPP_SP_DrugsDeliveryConsumerViewHeaderResult == null)
            {
                return NotFound();
            }

            return aPP_SP_DrugsDeliveryConsumerViewHeaderResult;
        }
        
        /*
        // PUT: api/APP_SP_DrugsDeliveryConsumerViewHeaderResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAPP_SP_DrugsDeliveryConsumerViewHeaderResult(string id, APP_SP_DrugsDeliveryConsumerViewHeaderResult aPP_SP_DrugsDeliveryConsumerViewHeaderResult)
        {
            if (id != aPP_SP_DrugsDeliveryConsumerViewHeaderResult.License)
            {
                return BadRequest();
            }

            _context.Entry(aPP_SP_DrugsDeliveryConsumerViewHeaderResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!APP_SP_DrugsDeliveryConsumerViewHeaderResultExists(id))
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
        
        // POST: api/APP_SP_DrugsDeliveryConsumerViewHeaderResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewHeaderResult>> PostAPP_SP_DrugsDeliveryConsumerViewHeaderResult(APP_SP_DrugsDeliveryConsumerViewHeaderResult aPP_SP_DrugsDeliveryConsumerViewHeaderResult)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewHeaderResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.APP_SP_DrugsDeliveryConsumerViewHeaderResult'  is null.");
          }
            _context.APP_SP_DrugsDeliveryConsumerViewHeaderResult.Add(aPP_SP_DrugsDeliveryConsumerViewHeaderResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (APP_SP_DrugsDeliveryConsumerViewHeaderResultExists(aPP_SP_DrugsDeliveryConsumerViewHeaderResult.License))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAPP_SP_DrugsDeliveryConsumerViewHeaderResult", new { id = aPP_SP_DrugsDeliveryConsumerViewHeaderResult.License }, aPP_SP_DrugsDeliveryConsumerViewHeaderResult);
        }

        // DELETE: api/APP_SP_DrugsDeliveryConsumerViewHeaderResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAPP_SP_DrugsDeliveryConsumerViewHeaderResult(string id)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewHeaderResult == null)
            {
                return NotFound();
            }
            var aPP_SP_DrugsDeliveryConsumerViewHeaderResult = await _context.APP_SP_DrugsDeliveryConsumerViewHeaderResult.FindAsync(id);
            if (aPP_SP_DrugsDeliveryConsumerViewHeaderResult == null)
            {
                return NotFound();
            }

            _context.APP_SP_DrugsDeliveryConsumerViewHeaderResult.Remove(aPP_SP_DrugsDeliveryConsumerViewHeaderResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool APP_SP_DrugsDeliveryConsumerViewHeaderResultExists(string id)
        {
            return (_context.APP_SP_DrugsDeliveryConsumerViewHeaderResult?.Any(e => e.License == id)).GetValueOrDefault();
        }
        */
    }
}
