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
    public class APP_SP_DrugsDeliveryConsumerViewSaveResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public APP_SP_DrugsDeliveryConsumerViewSaveResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/APP_SP_DrugsDeliveryConsumerViewSaveResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewSaveResult>>> GetAPP_SP_DrugsDeliveryConsumerViewSaveResult()
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult == null)
          {
              return NotFound();
          }
            return await _context.APP_SP_DrugsDeliveryConsumerViewSaveResult.ToListAsync();
        }

        // GET: api/APP_SP_DrugsDeliveryConsumerViewSaveResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult>> GetAPP_SP_DrugsDeliveryConsumerViewSaveResult(string id)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult == null)
          {
              return NotFound();
          }
            var aPP_SP_DrugsDeliveryConsumerViewSaveResult = await _context.APP_SP_DrugsDeliveryConsumerViewSaveResult.FindAsync(id);

            if (aPP_SP_DrugsDeliveryConsumerViewSaveResult == null)
            {
                return NotFound();
            }

            return aPP_SP_DrugsDeliveryConsumerViewSaveResult;
        }

        // PUT: api/APP_SP_DrugsDeliveryConsumerViewSaveResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAPP_SP_DrugsDeliveryConsumerViewSaveResult(string id, APP_SP_DrugsDeliveryConsumerViewSaveResult aPP_SP_DrugsDeliveryConsumerViewSaveResult)
        {
            if (id != aPP_SP_DrugsDeliveryConsumerViewSaveResult.P_DrugsConsumptionDetail)
            {
                return BadRequest();
            }

            _context.Entry(aPP_SP_DrugsDeliveryConsumerViewSaveResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!APP_SP_DrugsDeliveryConsumerViewSaveResultExists(id))
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

        /*
        // POST: api/APP_SP_DrugsDeliveryConsumerViewSaveResult
        [HttpPost]
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
        */



        /*
        
        // POST: api/APP_SP_DrugsDeliveryConsumerViewSaveResult
        [HttpPost]
        public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewArticlesResult>>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, [FromBody] GlappDrugsDeliveryConsumptionDet[] glappDrugsDeliveryConsumptionDet)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }
            //return await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.ToListAsync();
            
                return _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult
                  .FromSqlRaw($" EXEC APP_SP_DrugsDeliveryConsumerViewSave 'ADMIN' , 'HFQ753' , '"+glappDrugsDeliveryConsumptionDet+"' ").ToList();
        }
        */



        // POST: api/APP_SP_DrugsDeliveryConsumerViewSaveResult
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryConfirmationResult>>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, [FromBody] GlappDrugsDeliveryConsumptionDet[] glappDrugsDeliveryConsumptionDet)
        {
            if (_context.Glapp_SP_DrugsDeliveryConfirmationResult == null)
            {
                return NotFound();
            }
            //return await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.ToListAsync();

            return _context.Glapp_SP_DrugsDeliveryConfirmationResult
              .FromSqlRaw($" EXEC APP_SP_DrugsDeliveryConsumerViewSave 'ADMIN' , 'HFQ753' , '" + glappDrugsDeliveryConsumptionDet + "' ").ToList();
        }









        /*
        // POST: api/APP_SP_DrugsDeliveryConsumerViewSaveResult
        [HttpPost]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(APP_SP_DrugsDeliveryConsumerViewSaveResult aPP_SP_DrugsDeliveryConsumerViewSaveResult)
        //public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, string P_DrugsConsumptionDetail)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult == null)
            {
                return Problem("Entity set 'SISMEDICAERPContext.APP_SP_DrugsDeliveryConsumerViewSaveResult'  is null.");
            }

            _context.APP_SP_DrugsDeliveryConsumerViewSaveResult.Add(aPP_SP_DrugsDeliveryConsumerViewSaveResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (APP_SP_DrugsDeliveryConsumerViewSaveResultExists(aPP_SP_DrugsDeliveryConsumerViewSaveResult.P_DrugsConsumptionDetail))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAPP_SP_DrugsDeliveryConsumerViewSaveResult", new { id = aPP_SP_DrugsDeliveryConsumerViewSaveResult.P_DrugsConsumptionDetail }, aPP_SP_DrugsDeliveryConsumerViewSaveResult);

            //return _context.APP_SP_DrugsDeliveryConsumerViewSaveResult;
            //return NoContent();
        }
        */


        /*
        // POST: api/APP_SP_DrugsDeliveryConsumerViewSaveResult
        [HttpPost]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(APP_SP_DrugsDeliveryConsumerViewSaveResult aPP_SP_DrugsDeliveryConsumerViewSaveResult)
        //public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewSaveResult>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, string P_DrugsConsumptionDetail)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.APP_SP_DrugsDeliveryConsumerViewSaveResult'  is null.");
          }
            
            _context.APP_SP_DrugsDeliveryConsumerViewSaveResult.Add(aPP_SP_DrugsDeliveryConsumerViewSaveResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (APP_SP_DrugsDeliveryConsumerViewSaveResultExists(aPP_SP_DrugsDeliveryConsumerViewSaveResult.P_DrugsConsumptionDetail))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAPP_SP_DrugsDeliveryConsumerViewSaveResult", new { id = aPP_SP_DrugsDeliveryConsumerViewSaveResult.P_DrugsConsumptionDetail }, aPP_SP_DrugsDeliveryConsumerViewSaveResult);
            
            //return _context.APP_SP_DrugsDeliveryConsumerViewSaveResult;
            //return NoContent();
        }
        */

        // DELETE: api/APP_SP_DrugsDeliveryConsumerViewSaveResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAPP_SP_DrugsDeliveryConsumerViewSaveResult(string id)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult == null)
            {
                return NotFound();
            }
            var aPP_SP_DrugsDeliveryConsumerViewSaveResult = await _context.APP_SP_DrugsDeliveryConsumerViewSaveResult.FindAsync(id);
            if (aPP_SP_DrugsDeliveryConsumerViewSaveResult == null)
            {
                return NotFound();
            }

            _context.APP_SP_DrugsDeliveryConsumerViewSaveResult.Remove(aPP_SP_DrugsDeliveryConsumerViewSaveResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool APP_SP_DrugsDeliveryConsumerViewSaveResultExists(string id)
        {
            return (_context.APP_SP_DrugsDeliveryConsumerViewSaveResult?.Any(e => e.P_DrugsConsumptionDetail == id)).GetValueOrDefault();
        }
    }
}
