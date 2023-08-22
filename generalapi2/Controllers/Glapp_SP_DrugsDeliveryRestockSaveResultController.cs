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
    public class Glapp_SP_DrugsDeliveryRestockSaveResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public Glapp_SP_DrugsDeliveryRestockSaveResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }



        // POST: api/Glapp_SP_DrugsDeliveryRestockSaveResult
        [HttpPost]
        //public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewSaveResult2>>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, [FromBody] GlappDrugsDeliveryConsumptionDet[] glappDrugsDeliveryConsumptionDet)
        //public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewSaveResult2>>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, [FromBody] List<GlappDrugsDeliveryConsumptionDet> glappDrugsDeliveryConsumptionDet)
        //public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewSaveResult2>>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, JsonObject glappDrugsDeliveryConsumptionDet)
        //public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewSaveResult2>>> PostAPP_SP_DrugsDeliveryConsumerViewSaveResult(string P_ConsumerUser, string P_Vehicle, string glappDrugsDeliveryConsumptionDet)
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryRestockSaveResult2>>> PostGlapp_SP_DrugsDeliveryRestockSaveResult(int P_RestockID,string P_ConsumerUser, string P_Vehicle, JsonArray glappDrugsDeliveryConsumptionDet)
        {
            if (_context.Glapp_SP_DrugsDeliveryRestockSaveResult2 == null)
            {
                return NotFound();
            }

            /*
            List<GlappDrugsDeliveryConsumptionDet> lista = new List<GlappDrugsDeliveryConsumptionDet>(); ;
            foreach (var consum in glappDrugsDeliveryConsumptionDet)
            {
                lista.Add(consum);
            }
            */

            return _context.Glapp_SP_DrugsDeliveryRestockSaveResult2
              .FromSqlRaw($" EXEC Glapp_SP_DrugsDeliveryRestockSave -1, 'ADMIN', 'HFQ753','" + glappDrugsDeliveryConsumptionDet.ToJsonString().Replace("{", "{{").Replace("}", "}}") + "' ").ToList();
        }


        /*
        // GET: api/Glapp_SP_DrugsDeliveryRestockSaveResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryRestockSaveResult>>> GetGlapp_SP_DrugsDeliveryRestockSaveResult()
        {
          if (_context.Glapp_SP_DrugsDeliveryRestockSaveResult == null)
          {
              return NotFound();
          }
            return await _context.Glapp_SP_DrugsDeliveryRestockSaveResult.ToListAsync();
        }

        // GET: api/Glapp_SP_DrugsDeliveryRestockSaveResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestockSaveResult>> GetGlapp_SP_DrugsDeliveryRestockSaveResult(string id)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestockSaveResult == null)
          {
              return NotFound();
          }
            var glapp_SP_DrugsDeliveryRestockSaveResult = await _context.Glapp_SP_DrugsDeliveryRestockSaveResult.FindAsync(id);

            if (glapp_SP_DrugsDeliveryRestockSaveResult == null)
            {
                return NotFound();
            }

            return glapp_SP_DrugsDeliveryRestockSaveResult;
        }

        // PUT: api/Glapp_SP_DrugsDeliveryRestockSaveResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlapp_SP_DrugsDeliveryRestockSaveResult(string id, Glapp_SP_DrugsDeliveryRestockSaveResult glapp_SP_DrugsDeliveryRestockSaveResult)
        {
            if (id != glapp_SP_DrugsDeliveryRestockSaveResult.P_ConsumerUser)
            {
                return BadRequest();
            }

            _context.Entry(glapp_SP_DrugsDeliveryRestockSaveResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Glapp_SP_DrugsDeliveryRestockSaveResultExists(id))
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

        // POST: api/Glapp_SP_DrugsDeliveryRestockSaveResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestockSaveResult>> PostGlapp_SP_DrugsDeliveryRestockSaveResult(Glapp_SP_DrugsDeliveryRestockSaveResult glapp_SP_DrugsDeliveryRestockSaveResult)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestockSaveResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.Glapp_SP_DrugsDeliveryRestockSaveResult'  is null.");
          }
            _context.Glapp_SP_DrugsDeliveryRestockSaveResult.Add(glapp_SP_DrugsDeliveryRestockSaveResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Glapp_SP_DrugsDeliveryRestockSaveResultExists(glapp_SP_DrugsDeliveryRestockSaveResult.P_ConsumerUser))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGlapp_SP_DrugsDeliveryRestockSaveResult", new { id = glapp_SP_DrugsDeliveryRestockSaveResult.P_ConsumerUser }, glapp_SP_DrugsDeliveryRestockSaveResult);
        }

        // DELETE: api/Glapp_SP_DrugsDeliveryRestockSaveResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlapp_SP_DrugsDeliveryRestockSaveResult(string id)
        {
            if (_context.Glapp_SP_DrugsDeliveryRestockSaveResult == null)
            {
                return NotFound();
            }
            var glapp_SP_DrugsDeliveryRestockSaveResult = await _context.Glapp_SP_DrugsDeliveryRestockSaveResult.FindAsync(id);
            if (glapp_SP_DrugsDeliveryRestockSaveResult == null)
            {
                return NotFound();
            }

            _context.Glapp_SP_DrugsDeliveryRestockSaveResult.Remove(glapp_SP_DrugsDeliveryRestockSaveResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool Glapp_SP_DrugsDeliveryRestockSaveResultExists(string id)
        {
            return (_context.Glapp_SP_DrugsDeliveryRestockSaveResult?.Any(e => e.P_ConsumerUser == id)).GetValueOrDefault();
        }
        */
    }
}
