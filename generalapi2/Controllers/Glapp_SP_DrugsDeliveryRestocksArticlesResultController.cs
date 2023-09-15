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
    public class Glapp_SP_DrugsDeliveryRestocksArticlesResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public Glapp_SP_DrugsDeliveryRestocksArticlesResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryRestocksArticlesResult>>> Glapp_SP_DrugsDeliveryRestocksArticlesResult(string P_User,int P_RestockID,string P_View)
        {
            if (_context.Glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
            {
                return NotFound();
            }
            //return await _context.APP_SP_DrugsDeliveryConsumerViewArticlesResult.ToListAsync();
            return _context.Glapp_SP_DrugsDeliveryRestocksArticlesResult
                  .FromSqlRaw($"exec Glapp_SP_DrugsDeliveryRestocksArticles '{P_User}',{P_RestockID},'{P_View}'")  //pview =RESTOCK_REQUEST
                  .ToList();
        }

        /*
        // GET: api/Glapp_SP_DrugsDeliveryRestocksArticlesResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Glapp_SP_DrugsDeliveryRestocksArticlesResult>>> GetGlapp_SP_DrugsDeliveryRestocksArticlesResult()
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
          {
              return NotFound();
          }
            return await _context.Glapp_SP_DrugsDeliveryRestocksArticlesResult.ToListAsync();
        }
        */


        /*
        // GET: api/Glapp_SP_DrugsDeliveryRestocksArticlesResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestocksArticlesResult>> GetGlapp_SP_DrugsDeliveryRestocksArticlesResult(string id)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
          {
              return NotFound();
          }
            var glapp_SP_DrugsDeliveryRestocksArticlesResult = await _context.Glapp_SP_DrugsDeliveryRestocksArticlesResult.FindAsync(id);

            if (glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
            {
                return NotFound();
            }

            return glapp_SP_DrugsDeliveryRestocksArticlesResult;
        }

        // PUT: api/Glapp_SP_DrugsDeliveryRestocksArticlesResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGlapp_SP_DrugsDeliveryRestocksArticlesResult(string id, Glapp_SP_DrugsDeliveryRestocksArticlesResult glapp_SP_DrugsDeliveryRestocksArticlesResult)
        {
            if (id != glapp_SP_DrugsDeliveryRestocksArticlesResult.ArticleCode)
            {
                return BadRequest();
            }

            _context.Entry(glapp_SP_DrugsDeliveryRestocksArticlesResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Glapp_SP_DrugsDeliveryRestocksArticlesResultExists(id))
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

        // POST: api/Glapp_SP_DrugsDeliveryRestocksArticlesResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Glapp_SP_DrugsDeliveryRestocksArticlesResult>> PostGlapp_SP_DrugsDeliveryRestocksArticlesResult(Glapp_SP_DrugsDeliveryRestocksArticlesResult glapp_SP_DrugsDeliveryRestocksArticlesResult)
        {
          if (_context.Glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.Glapp_SP_DrugsDeliveryRestocksArticlesResult'  is null.");
          }
            _context.Glapp_SP_DrugsDeliveryRestocksArticlesResult.Add(glapp_SP_DrugsDeliveryRestocksArticlesResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (Glapp_SP_DrugsDeliveryRestocksArticlesResultExists(glapp_SP_DrugsDeliveryRestocksArticlesResult.ArticleCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGlapp_SP_DrugsDeliveryRestocksArticlesResult", new { id = glapp_SP_DrugsDeliveryRestocksArticlesResult.ArticleCode }, glapp_SP_DrugsDeliveryRestocksArticlesResult);
        }

        // DELETE: api/Glapp_SP_DrugsDeliveryRestocksArticlesResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGlapp_SP_DrugsDeliveryRestocksArticlesResult(string id)
        {
            if (_context.Glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
            {
                return NotFound();
            }
            var glapp_SP_DrugsDeliveryRestocksArticlesResult = await _context.Glapp_SP_DrugsDeliveryRestocksArticlesResult.FindAsync(id);
            if (glapp_SP_DrugsDeliveryRestocksArticlesResult == null)
            {
                return NotFound();
            }

            _context.Glapp_SP_DrugsDeliveryRestocksArticlesResult.Remove(glapp_SP_DrugsDeliveryRestocksArticlesResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        private bool Glapp_SP_DrugsDeliveryRestocksArticlesResultExists(string id)
        {
            return (_context.Glapp_SP_DrugsDeliveryRestocksArticlesResult?.Any(e => e.ArticleCode == id)).GetValueOrDefault();
        }
    }
}
