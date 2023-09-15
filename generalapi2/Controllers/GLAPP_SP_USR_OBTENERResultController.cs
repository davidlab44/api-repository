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
    public class GLAPP_SP_USR_OBTENERResultController : ControllerBase
    {
        private readonly SISMEDICAERPContext _context;

        public GLAPP_SP_USR_OBTENERResultController(SISMEDICAERPContext context)
        {
            _context = context;
        }


        //POST: api/GLAPP_SP_USR_OBTENERResult
        [HttpPost]
        public async Task<ActionResult<IEnumerable<GLAPP_SP_USR_OBTENERResult>>> PostGlapp_SP_DrugsDeliveryRestockSaveResult(string P_USUARIO, string P_CLAVE)
        {
            if (_context.GLAPP_SP_USR_OBTENERResult == null)
            {
                return NotFound();
            }
            return _context.GLAPP_SP_USR_OBTENERResult
              //.FromSqlRaw($" EXEC GLAPP_SP_USR_OBTENER 'Admin', 'Med1co2011' ").ToList();
              .FromSqlRaw($" EXEC GLAPP_SP_USR_OBTENER '{P_USUARIO}', '{P_CLAVE}' ").ToList();
        }



        /*
        // GET: api/GLAPP_SP_USR_OBTENERResult
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GLAPP_SP_USR_OBTENERResult>>> GetGLAPP_SP_USR_OBTENERResult()
        {
          if (_context.GLAPP_SP_USR_OBTENERResult == null)
          {
              return NotFound();
          }
            return await _context.GLAPP_SP_USR_OBTENERResult.ToListAsync();
        }

        // GET: api/GLAPP_SP_USR_OBTENERResult/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GLAPP_SP_USR_OBTENERResult>> GetGLAPP_SP_USR_OBTENERResult(string id)
        {
          if (_context.GLAPP_SP_USR_OBTENERResult == null)
          {
              return NotFound();
          }
            var gLAPP_SP_USR_OBTENERResult = await _context.GLAPP_SP_USR_OBTENERResult.FindAsync(id);

            if (gLAPP_SP_USR_OBTENERResult == null)
            {
                return NotFound();
            }

            return gLAPP_SP_USR_OBTENERResult;
        }

        // PUT: api/GLAPP_SP_USR_OBTENERResult/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutGLAPP_SP_USR_OBTENERResult(string id, GLAPP_SP_USR_OBTENERResult gLAPP_SP_USR_OBTENERResult)
        {
            if (id != gLAPP_SP_USR_OBTENERResult.USUARIO)
            {
                return BadRequest();
            }

            _context.Entry(gLAPP_SP_USR_OBTENERResult).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!GLAPP_SP_USR_OBTENERResultExists(id))
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

        // POST: api/GLAPP_SP_USR_OBTENERResult
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<GLAPP_SP_USR_OBTENERResult>> PostGLAPP_SP_USR_OBTENERResult(GLAPP_SP_USR_OBTENERResult gLAPP_SP_USR_OBTENERResult)
        {
          if (_context.GLAPP_SP_USR_OBTENERResult == null)
          {
              return Problem("Entity set 'SISMEDICAERPContext.GLAPP_SP_USR_OBTENERResult'  is null.");
          }
            _context.GLAPP_SP_USR_OBTENERResult.Add(gLAPP_SP_USR_OBTENERResult);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (GLAPP_SP_USR_OBTENERResultExists(gLAPP_SP_USR_OBTENERResult.USUARIO))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetGLAPP_SP_USR_OBTENERResult", new { id = gLAPP_SP_USR_OBTENERResult.USUARIO }, gLAPP_SP_USR_OBTENERResult);
        }

        // DELETE: api/GLAPP_SP_USR_OBTENERResult/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGLAPP_SP_USR_OBTENERResult(string id)
        {
            if (_context.GLAPP_SP_USR_OBTENERResult == null)
            {
                return NotFound();
            }
            var gLAPP_SP_USR_OBTENERResult = await _context.GLAPP_SP_USR_OBTENERResult.FindAsync(id);
            if (gLAPP_SP_USR_OBTENERResult == null)
            {
                return NotFound();
            }

            _context.GLAPP_SP_USR_OBTENERResult.Remove(gLAPP_SP_USR_OBTENERResult);
            await _context.SaveChangesAsync();

            return NoContent();
        }
        */
        private bool GLAPP_SP_USR_OBTENERResultExists(string id)
        {
            return (_context.GLAPP_SP_USR_OBTENERResult?.Any(e => e.USUARIO == id)).GetValueOrDefault();
        }
    }
}
