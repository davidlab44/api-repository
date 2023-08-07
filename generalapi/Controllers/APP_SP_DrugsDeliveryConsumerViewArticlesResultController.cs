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
    public class APP_SP_DrugsDeliveryConsumerViewArticlesResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public APP_SP_DrugsDeliveryConsumerViewArticlesResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        // GET: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<APP_SP_DrugsDeliveryConsumerViewArticlesResult>>> GetAPP_SP_DrugsDeliveryConsumerViewArticlesResult()
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
          {
              return NotFound();
          }
            //return await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.ToListAsync();
            return _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult
                  .FromSqlRaw($"exec APP_SP_DrugsDeliveryConsumerViewArticles 'admin'")
                  .ToList();
        }

        // GET: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> GetAPP_SP_DrugsDeliveryConsumerViewArticlesResult(string id)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
          {
              return NotFound();
          }
            var aPP_SP_DrugsDeliveryConsumerViewArticlesResult = await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.FindAsync(id);

            if (aPP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }

            return aPP_SP_DrugsDeliveryConsumerViewArticlesResult;
        }

        // PUT: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAPP_SP_DrugsDeliveryConsumerViewArticlesResult(string id, APP_SP_DrugsDeliveryConsumerViewArticlesResult aPP_SP_DrugsDeliveryConsumerViewArticlesResult)
        {
            if (id != aPP_SP_DrugsDeliveryConsumerViewArticlesResult.ArticleCode)
            {
                return BadRequest();
            }

            _context.Entry(aPP_SP_DrugsDeliveryConsumerViewArticlesResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!APP_SP_DrugsDeliveryConsumerViewArticlesResultExists(id))
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

        // POST: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<APP_SP_DrugsDeliveryConsumerViewArticlesResult>> PostAPP_SP_DrugsDeliveryConsumerViewArticlesResult(APP_SP_DrugsDeliveryConsumerViewArticlesResult aPP_SP_DrugsDeliveryConsumerViewArticlesResult)
        {
          if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.APP_SP_DrugsDeliveryConsumerViewArticlesResult'  is null.");
          }
            _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.Add(aPP_SP_DrugsDeliveryConsumerViewArticlesResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (APP_SP_DrugsDeliveryConsumerViewArticlesResultExists(aPP_SP_DrugsDeliveryConsumerViewArticlesResult.ArticleCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAPP_SP_DrugsDeliveryConsumerViewArticlesResult", new { id = aPP_SP_DrugsDeliveryConsumerViewArticlesResult.ArticleCode }, aPP_SP_DrugsDeliveryConsumerViewArticlesResult);
        }

        // DELETE: api/APP_SP_DrugsDeliveryConsumerViewArticlesResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAPP_SP_DrugsDeliveryConsumerViewArticlesResult(string id)
        {
            if (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }
            var aPP_SP_DrugsDeliveryConsumerViewArticlesResult = await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.FindAsync(id);
            if (aPP_SP_DrugsDeliveryConsumerViewArticlesResult == null)
            {
                return NotFound();
            }

            _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.Remove(aPP_SP_DrugsDeliveryConsumerViewArticlesResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool APP_SP_DrugsDeliveryConsumerViewArticlesResultExists(string id)
        {
            return (_context.APP_SP_DrugsDeliveryConsumerViewArticlesResult?.Any(e => e.ArticleCode == id)).GetValueOrDefault();
        }
    }
}
